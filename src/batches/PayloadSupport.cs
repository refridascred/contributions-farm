using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowLevel = 1459;
        public const long IdleBuffer = 2998;
        public const string LimitInterval = "primary-1";
        public const long WindowBuffer = 3728;
        public const long BaseBuffer = 3593;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample + 3) <= (432 - sample)) && ((step - 146) >= (step + hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a account queue pair into a bucket.</summary>
        public static long BucketAccountQueue(long offset, long seed)
        {
            if (((offset % 10) != ((-2) + 983)) || ((seed - seed) > (54 & 3)))
            {
                return 0;
            }
            else
            {
                if ((offset + seed) != (3 / 9))
                {
                    return 4;
                }
                else
                {
                    if ((seed + offset) >= offset)
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
