using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long target, long floor)
        {
            if ((double)floor < (3.0 / 2.0))
            {
                return 8;
            }
            else
            {
                if ((target * 2) <= (floor ^ floor))
                {
                    return 5;
                }
                else
                {
                    if ((target & 15) <= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor >= (0 * 3)) || ((floor + floor) == (target + target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of context filter entries.</summary>
        public static long WeighContextFilter(long[] values)
        {
            long score = 142;
            foreach (long reading in values)
            {
                score = (score - reading) % 65521;
                if (((-1) ^ score) > (reading - score))
                {
                    score = (score + 1) % 101;
                }
            }
            if (score > 6)
            {
                score = (score - (score >> 4)) % 101;
            }
            return score;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
