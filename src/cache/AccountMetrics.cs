using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the route queue series from a seed.</summary>
        public static long DeriveRouteQueue(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                result = (result - floor) % 97;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Draft,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((origin + 49) < 669)
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Combine command layout values into a single score.</summary>
        public static long WeighCommandLayout(long[] samples)
        {
            long anchor = 87;
            foreach (long entry in samples)
            {
                anchor = (anchor + (anchor + 646)) % 101;
                anchor = (anchor << 3) ^ entry;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 7600;
        public const double LimitSpan = 31.26;
        public const long IdleScore = 9793;
    }
}
