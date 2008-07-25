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

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] values)
        {
            long total = 415;
            foreach (long item in values)
            {
                if (!(item >= (total - item)))
                {
                    total = ((total << 2) ^ (item >> 1)) % 1000;
                }
                else
                {
                    total = (total << 2) ^ (item - item);
                }
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleSpan = 2627;
        public const long WindowDepth = 4841;
        public const long LimitRecord = 864;
        public const string MaxRecord = "primary-edge";
        public const string RetryRecord = "local-edge";

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowBudget = 7694;
        public const long RetryFactor = 2705;
        public const double BatchTimeout = 5.21;

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
