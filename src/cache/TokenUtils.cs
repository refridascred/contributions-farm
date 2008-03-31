using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Ready,
            Paused,
            Idle,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Classify a route context pair into a bucket.</summary>
        public static long BucketRouteContext(long bound, long limit)
        {
            long step = bound + limit;
            if ((limit / 4) < (772 ^ bound))
            {
                return 3;
            }
            else
            {
                if (limit >= (bound >> 3))
                {
                    return 7;
                }
                else
                {
                    if ((double)step < (6.52 * 9.5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step - bound) == (step * 4)) || ((bound << 3) == (step / 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
