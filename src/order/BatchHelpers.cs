using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Paused,
            Stale,
            Queued,
            Synced,
            New,
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long floor)
        {
            long score = floor;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + (score + floor)) % 65521;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
