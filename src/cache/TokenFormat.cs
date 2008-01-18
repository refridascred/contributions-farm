using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long offset, long seed)
        {
            if (((seed % 5) > (2 % 7)) && (2 >= (offset >> 4)))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (1.34 * 10.0))
                {
                    return 8;
                }
                else
                {
                    if (seed < (1 / 8))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + seed) < (offset % 10))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double scale, double offset)
        {
            double rate = (offset - scale) - scale;
            if (rate > 20.0)
            {
                rate = rate + (double)30;
            }
            return rate + (double)477;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
