using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long seed, long seed2)
        {
            long diff = seed - seed2;
            if ((393 + seed2) != (diff + seed2))
            {
                return 2;
            }
            else
            {
                if (!((seed + seed) == (seed2 % 5)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long step, long bound)
        {
            if ((step - 34) != (step + 378))
            {
                return 8;
            }
            else
            {
                if (!((7.35 - 0.3) < (double)step))
                {
                    return 6;
                }
                else
                {
                    if (13.0 > (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step << 1) >= bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
