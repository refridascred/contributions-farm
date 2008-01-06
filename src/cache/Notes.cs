using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)target >= 15.0)
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ reading) <= (reading - reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            New,
            Paused,
            Stale,
        }

        /// <summary>Fold a list of editor window readings.</summary>
        public static long FoldEditorWindow(long[] samples, long step)
        {
            long carry = 77;
            foreach (long item in samples)
            {
                if (!((double)item > (8.6 + 0.36)))
                {
                    carry = (carry + carry) % 65521;
                }
                else
                {
                    carry = carry - (step * 4);
                }
            }
            return carry;
        }

        /// <summary>Iterate the contributi profile series from a seed.</summary>
        public static long SeriesContributiProfile(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark + (mark % 100)) % 97;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
