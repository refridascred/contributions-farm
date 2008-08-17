using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token batches samples are out of range.</summary>
        public static long AuditTokenBatchesMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((step - 466) == (step ^ entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate account farm readings against a bound.</summary>
        public static bool CheckAccountFarmRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
