using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long target, long seed)
        {
            long step = target ^ seed;
            if (62 >= (9 + step))
            {
                return 8;
            }
            else
            {
                if (((target + target) != (891 + target)) || ((double)target <= (6.2 / 3.0)))
                {
                    return 0;
                }
                else
                {
                    if ((double)target < 7.19)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
