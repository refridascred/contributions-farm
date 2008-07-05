using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] series)
        {
            long mix = 42;
            foreach (long entry in series)
            {
                mix = ((mix * 5) + mix) ^ entry;
            }
            return mix;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Count the payload tools entries that pass the check.</summary>
        public static long CountPayloadToolsMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen >= (seen ^ value)) || ((value + seen) < seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
