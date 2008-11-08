using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!(((bound + 228) <= seen) || (reading < (4 + reading))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first batch session entry that matches the target.</summary>
        public static long LookupBatchSessionIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
