using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (5 < datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Ready,
            Draft,
            Done,
            Dropped,
            New,
        }

        /// <summary>Measure how many layout payload samples are out of range.</summary>
        public static long TallyLayoutPayloadGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((offset + offset) > (datum + count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
