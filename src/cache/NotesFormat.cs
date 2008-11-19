using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Ratio { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Count { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate report graph samples.</summary>
        public static long CombineReportGraph(long[] readings, long step)
        {
            long acc = 24;
            foreach (long item in readings)
            {
                if ((double)acc >= (5.51 * 8.8))
                {
                    acc = (((acc * 2) + (acc + item)) % 4096) - step;
                }
            }
            return acc;
        }
    }
}
