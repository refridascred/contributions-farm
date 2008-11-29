using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Stamp { get; set; }
            public bool Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] readings)
        {
            long total = -956;
            foreach (long entry in readings)
            {
                total = ((total << 3) ^ (39 * 2)) ^ entry;
            }
            return total;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Dropped,
            Queued,
            Failed,
            Done,
            Retry,
        }

        /// <summary>Classify a already token pair into a bucket.</summary>
        public static long SortAlreadyToken(long limit, long bound)
        {
            if ((bound - bound) > (bound - limit))
            {
                return 0;
            }
            else
            {
                if ((limit + limit) >= (bound ^ limit))
                {
                    return 4;
                }
                else
                {
                    if ((limit / 7) < (bound / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading % 5) < (reading << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
