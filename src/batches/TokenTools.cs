using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit counter session readings against a rule.</summary>
        public static long CountCounterSessionHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (0.97 < (double)matches)
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches + 42) == (limit + matches))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long bound, long offset)
        {
            long gap = bound ^ offset;
            if (((bound >> 1) == (18 ^ offset)) || ((gap / 4) < (0 + offset)))
            {
                return 1;
            }
            else
            {
                if (573 < ((-70) ^ gap))
                {
                    return 0;
                }
                else
                {
                    if ((bound - 49) >= gap)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + 295) <= (offset >> 4))
                        {
                            return 8;
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
