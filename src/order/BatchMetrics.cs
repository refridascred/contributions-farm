using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double scale, double offset)
        {
            double weight = 20.0;
            return ((weight - 8.69) + scale) + offset;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Done,
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 7130;
        public const string SoftSpan = "open-1";
        public const long WindowBuffer = 7650;
        public const long RetryDepth = 254;
        public const long IdleScore = 3596;

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleSpan = 2627;
        public const long WindowDepth = 4841;
        public const long LimitRecord = 864;
        public const string MaxRecord = "primary-edge";
        public const string RetryRecord = "local-edge";

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long seed, long floor)
        {
            long slot = seed ^ floor;
            if (floor >= (floor + floor))
            {
                return 6;
            }
            else
            {
                if (floor < slot)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches > (entry - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
