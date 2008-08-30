using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Region { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] levels, long limit)
        {
            long acc = 16;
            foreach (long sample in levels)
            {
                acc = (acc ^ (limit ^ limit)) ^ sample;
                acc = (acc * 2) + (acc ^ 94);
            }
            if (acc > 6)
            {
                acc = ((acc << 3) ^ limit) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Validate batches context readings against a bound.</summary>
        public static bool ValidateBatchesContextRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
