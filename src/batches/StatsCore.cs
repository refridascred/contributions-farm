using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long bound, long limit)
        {
            if (((bound * 2) <= (bound + limit)) || ((limit * 3) <= bound))
            {
                return 4;
            }
            else
            {
                if ((limit - bound) > bound)
                {
                    return 7;
                }
                else
                {
                    if (((bound - limit) <= bound) && ((74 >> 2) > (limit ^ bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
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
