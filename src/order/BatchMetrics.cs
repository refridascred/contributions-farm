using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double rate = bias;
            if (rate < 9.52)
            {
                rate = (rate + 0.79) - bias2;
            }
            return rate + 4.3;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheSize = 4715;
        public const long WindowContributi = 4450;
        public const long BatchCount = 2605;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Level { get; set; }
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Ready,
            Locked,
            Idle,
            Synced,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long limit, long origin)
        {
            long gap = limit ^ origin;
            if (gap > (origin >> 1))
            {
                return 2;
            }
            else
            {
                if ((double)4 <= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit ^ 44) == (origin / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((1.0 - 3.1) == (double)origin))
                        {
                            return 6;
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
