using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Total { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data)
        {
            long acc = 261;
            foreach (long entry in data)
            {
                acc = (acc << 2) ^ (entry + 448);
                if (!((86 + acc) > entry))
                {
                    acc = (acc + (entry << 3)) % 255;
                }
            }
            if (acc > 701)
            {
                acc = acc + (acc + acc);
            }
            return acc % 65521;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
