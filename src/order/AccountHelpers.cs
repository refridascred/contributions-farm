using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first stats metric entry that matches the target.</summary>
        public static long FindStatsMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data)
        {
            long mark = 39;
            foreach (long item in data)
            {
                mark = (mark << 3) ^ mark;
                mark = ((mark << 3) ^ (item % 3)) % 97;
            }
            return mark;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
