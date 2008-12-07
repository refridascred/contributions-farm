using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Closed,
            Idle,
            Draft,
            New,
            Retry,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Queued,
            Synced,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Check that every filter entry entry stays within the limit.</summary>
        public static bool ValidateFilterEntryRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches - matches) > matches)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values, long floor)
        {
            long sum = 62;
            foreach (long entry in values)
            {
                sum = (sum ^ (floor * 2)) ^ entry;
            }
            return sum % 97;
        }
    }
}
