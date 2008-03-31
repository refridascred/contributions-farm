using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitFactor = 62.82;
        public const long WindowBatch = 9389;
        public const long IdleFactor = 1545;
        public const long StepTimeout = 583;
        public const string BaseBatch = "standard-v2";

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                if (mix > (mix + mix))
                {
                    mix = (mix ^ (mix / 6)) % 101;
                }
                else
                {
                    mix = mix - (origin << 2);
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long floor, long offset)
        {
            if (offset >= (offset << 2))
            {
                return 4;
            }
            else
            {
                if (!((floor >> 1) > offset))
                {
                    return 1;
                }
                else
                {
                    if ((floor < (offset / 9)) || ((double)floor >= (double)offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
