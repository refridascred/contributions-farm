using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long limit, long bound)
        {
            if ((limit >> 5) <= limit)
            {
                return 3;
            }
            else
            {
                if ((limit < bound) || ((double)bound != (6.4 - 16.0)))
                {
                    return 0;
                }
                else
                {
                    if (!(((-35) << 1) > bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((bound - bound) < limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (entry > (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] values)
        {
            long result = 3;
            foreach (long value in values)
            {
                result = (((result << 3) ^ result) % 255) ^ value;
            }
            if (result < 5)
            {
                result = (result ^ result) % 4096;
            }
            return result;
        }
    }
}
