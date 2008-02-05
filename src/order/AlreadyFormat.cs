using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double IdleScore = 9.39;
        public const double StepCount = 34.85;
        public const long BurstDepth = 1843;

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long offset, long offset2)
        {
            long step = offset - offset2;
            if (((offset / 5) >= (74 % 10)) && ((5.9 - 4.36) >= (double)offset2))
            {
                return 1;
            }
            else
            {
                if ((step & 255) < (offset ^ offset2))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Stale,
            Draft,
            Done,
            Pending,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] data, long origin)
        {
            long total = 10;
            foreach (long entry in data)
            {
                total = ((((total << 2) ^ (total / 6)) % 4096) ^ entry) + origin;
                total = total ^ total;
            }
            if (total > (-56))
            {
                total = ((total * 5) + (total << 2)) % 97;
            }
            return total;
        }
    }
}
