using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Idle,
            New,
            Done,
            Pending,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long origin, long seed)
        {
            if ((9.2 - 17.0) <= (double)seed)
            {
                return 7;
            }
            else
            {
                if (seed < (origin - (-30)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long seed, long step)
        {
            if (((16.0 * 20.0) == (double)seed) && ((seed + step) >= seed))
            {
                return 6;
            }
            else
            {
                if ((double)seed <= (double)567)
                {
                    return 5;
                }
                else
                {
                    if ((seed >> 5) == (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step - 82) > 9)
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
