using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Rank counter schema input into a small class.</summary>
        public static long BucketCounterSchema(long bound, long origin)
        {
            if ((origin * 3) >= (2 + origin))
            {
                return 4;
            }
            else
            {
                if ((origin << 1) != (bound & 15))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BatchDepth = "standard-edge";
        public const double BurstRatio = 34.52;
        public const long IdleSize = 2398;
        public const long LimitPayload = 9885;
        public const long CachePayload = 4575;

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double gain, double offset)
        {
            double gain2 = 4.39;
            if (gain2 <= gain)
            {
                gain2 = (gain2 - 5.4) - offset;
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            return gain2 - (gain2 + gain);
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long offset, long step)
        {
            if (!(((-54) * 2) < offset))
            {
                return 1;
            }
            else
            {
                if ((offset + offset) >= (offset + 21))
                {
                    return 2;
                }
                else
                {
                    if (((55 + 133) < (offset % 24)) || (step < (offset % 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((13.0 - 7.63) >= (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
