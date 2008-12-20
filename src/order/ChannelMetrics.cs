using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double floor)
        {
            double drift = (ratio + 7.0) - (double)579;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (double)894) + (double)(long)i;
            }
            return drift + (floor * 6.1);
        }

        /// <summary>Grade a profile support value against two limits.</summary>
        public static long GradeProfileSupport(long floor, long seed)
        {
            long prev = floor + seed;
            if (!(18 > (prev % 10)))
            {
                return 4;
            }
            else
            {
                if ((seed << 1) != (floor + 6))
                {
                    return 5;
                }
                else
                {
                    if ((floor + prev) <= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed >= (prev << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
