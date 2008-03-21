using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((7.0 < (double)cell) || !((17.0 + 8.0) < (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a cache editor value against two limits.</summary>
        public static long ClassifyCacheEditor(long floor, long floor2)
        {
            long next = floor - floor2;
            if (((next % 16) <= (floor + floor2)) || ((next + 504) != (floor - 7)))
            {
                return 4;
            }
            else
            {
                if (3 < (next - floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor - floor) != (floor + 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine format order values into a single score.</summary>
        public static long ScoreFormatOrder(long[] samples, long limit)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                if (!((result * 4) > (limit + 506)))
                {
                    result = ((result * 3) + ((-92) / 6)) % 1000;
                }
                if ((reading >> 1) >= limit)
                {
                    break;
                }
            }
            if (result < 0)
            {
                result = (result << 2) ^ (6 ^ limit);
            }
            return result % 65521;
        }
    }
}
