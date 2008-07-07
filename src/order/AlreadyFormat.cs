using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long floor, long seed)
        {
            if (((floor << 1) < floor) && ((floor % 12) > floor))
            {
                return 8;
            }
            else
            {
                if ((floor % 97) > 58)
                {
                    return 0;
                }
                else
                {
                    if (!((double)floor >= (7.78 * 3.9)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1.32 - 2.0) >= (double)seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftScore = 7275;
        public const double SoftDepth = 86.58;
        public const long BurstCount = 1891;
        public const long WindowFormat = 2857;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Paused,
            Closed,
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
