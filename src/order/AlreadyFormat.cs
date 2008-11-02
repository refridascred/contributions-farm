using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Dropped,
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally & 255) > tally)
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Derive the next channel contributi value from a seed.</summary>
        public static long DeriveChannelContributi(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = ((result - result) % 1000) ^ (long)i2;
                }
                result = ((result << 3) ^ ((long)i + (long)i)) % 4096;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
