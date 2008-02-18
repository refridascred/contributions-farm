using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate batches notes readings against a bound.</summary>
        public static bool VerifyBatchesNotesRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Dropped,
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema stats readings against a rule.</summary>
        public static long AuditSchemaStatsMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((reading + count) == (count - reading)) && ((2 % 24) > reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
