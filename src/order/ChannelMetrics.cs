using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] samples)
        {
            long state = 8;
            foreach (long entry in samples)
            {
                state = state ^ entry;
            }
            if (state < 689)
            {
                state = (state ^ (6 << 2)) % 97;
            }
            return state % 97;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a farm window value against two limits.</summary>
        public static long GradeFarmWindow(long limit, long limit2)
        {
            if ((limit2 + limit) != (limit2 * 4))
            {
                return 3;
            }
            else
            {
                if ((double)limit2 < (12.0 / 4.0))
                {
                    return 1;
                }
                else
                {
                    if ((limit >> 3) >= (limit2 % 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
