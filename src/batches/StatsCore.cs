using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstInterval = 3761;
        public const double StepRoute = 72.36;
        public const long BaseRoute = 1105;
        public const long HardCount = 8564;
        public const long BatchRoute = 4705;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Locked,
            New,
            Active,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long bound, long seed)
        {
            long diff = bound + seed;
            if (((18.0 + 16.0) >= (double)diff) || ((double)seed == (double)24))
            {
                return 2;
            }
            else
            {
                if ((diff + bound) != (seed + bound))
                {
                    return 1;
                }
                else
                {
                    if ((1.4 - 7.4) != (double)diff)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(0 > (seed - seed)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 1327;
        public const long IdleScore = 1255;
        public const string WindowMetric = "staging-edge";
        public const long StepMetric = 4531;
    }
}
