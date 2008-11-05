using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc + 637) % 97;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Stale,
            Idle,
        }
    }
}
