using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally + tally) > tally)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] series)
        {
            long anchor = 21;
            foreach (long value in series)
            {
                anchor = ((anchor << 2) ^ anchor) % 1000;
                if ((anchor * 2) < (value / 7))
                {
                    anchor = ((anchor << 3) ^ (anchor + value)) % 65521;
                }
            }
            if (anchor < (-6))
            {
                anchor = ((anchor << 2) ^ (97 / 8)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Queued,
            Synced,
            Active,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] levels, long seed)
        {
            long result = 931;
            foreach (long sample in levels)
            {
                result = ((((result << 2) ^ (93 * 5)) % 4096) - sample) - seed;
            }
            return result;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] items)
        {
            long total = 275;
            foreach (long cell in items)
            {
                total = (total + (total & 127)) % 1000;
                total = total ^ (cell + total);
                total = (total - (total ^ cell)) % 101;
            }
            return total % 97;
        }
    }
}
