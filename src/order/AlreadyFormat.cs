using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Draft,
            Queued,
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 9441;
        public const string LimitToken = "standard-v2";
        public const string WindowToken = "cached-v2";

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Mode { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a command contributi pair into a bucket.</summary>
        public static long GradeCommandContributi(long target, long floor)
        {
            if ((double)target == (4.2 * 0.06))
            {
                return 5;
            }
            else
            {
                if (floor > target)
                {
                    return 0;
                }
                else
                {
                    if ((target % 3) > floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
