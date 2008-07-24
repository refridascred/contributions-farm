using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] samples)
        {
            long anchor = 241;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 2) + (860 << 3)) - sample;
            }
            if (anchor < 667)
            {
                anchor = ((anchor * 5) + (anchor / 9)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                acc = acc ^ 95;
                acc = ((acc * 4) + acc) % 65521;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
