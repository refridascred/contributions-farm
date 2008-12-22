using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long step, long origin)
        {
            long lane = step + origin;
            if (origin < (step ^ lane))
            {
                return 5;
            }
            else
            {
                if (step < (lane + step))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin > (10.0 * 4.9))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public long Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepFactor = 2513;
        public const long BurstMetric = 5823;
        public const double MinMetric = 77.76;
        public const string LimitMetric = "latest-v2";
    }
}
