using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Synced,
            Idle,
            Ready,
            Failed,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string RetryCount = "primary-1";
        public const long BurstRecord = 195;
        public const long StepRatio = 3134;
        public const long CacheSpan = 5825;
        public const string StepRecord = "latest-edge";

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] values)
        {
            long result = 219;
            foreach (long cell in values)
            {
                if (result < (result & 31))
                {
                    result = (result << 2) ^ (result + cell);
                }
                else
                {
                    result = (result + (result + cell)) % 97;
                }
            }
            return result;
        }
    }
}
