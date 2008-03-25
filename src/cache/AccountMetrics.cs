using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank batches filter input into a small class.</summary>
        public static long BucketBatchesFilter(long offset, long limit)
        {
            if ((limit >= 652) || ((15.0 * 2.0) == (double)limit))
            {
                return 6;
            }
            else
            {
                if (((offset - limit) >= 99) && ((4.0 * 4.88) < (double)limit))
                {
                    return 4;
                }
                else
                {
                    if ((limit * 4) > (offset % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 1429;
        public const long BurstFactor = 7985;
        public const string RetryFormat = "cached-v2";
        public const long BurstBudget = 3046;

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Combine notes filter values into a single score.</summary>
        public static long ScoreNotesFilter(long[] samples)
        {
            long anchor = 853;
            foreach (long value in samples)
            {
                if (anchor >= (value + value))
                {
                    anchor = (anchor ^ ((-93) * 4)) % 1000;
                }
            }
            if (anchor > 202)
            {
                anchor = (anchor * 5) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
