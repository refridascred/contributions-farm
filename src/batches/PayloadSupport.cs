using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 7177;
        public const double SoftEntry = 1.32;
        public const long IdleLevel = 9766;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long seed, long limit)
        {
            if ((limit % 60) == (seed ^ seed))
            {
                return 1;
            }
            else
            {
                if ((double)seed != (4.0 * 2.41))
                {
                    return 6;
                }
                else
                {
                    if (seed >= (seed >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed <= (seed + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Stale,
            Pending,
            Retry,
            Ready,
        }
    }
}
