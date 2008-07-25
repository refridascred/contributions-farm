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

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long offset, long floor)
        {
            long gap = offset + floor;
            if ((double)gap != (7.0 * 16.0))
            {
                return 8;
            }
            else
            {
                if (((floor + offset) < (offset & 15)) && ((double)floor > (double)offset))
                {
                    return 1;
                }
                else
                {
                    if (((offset + offset) >= (389 / 4)) && ((1.57 * 4.0) != (double)offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if (gap < offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double bias, double span)
        {
            double weight = span;
            return weight + bias;
        }
    }
}
