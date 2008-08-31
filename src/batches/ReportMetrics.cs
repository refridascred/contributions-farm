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

        /// <summary>Roll a tools cluster counter forward.</summary>
        public static long SeriesToolsCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = (total << 2) ^ (total & 127);
                if ((double)total >= (15.0 - 1.1))
                {
                    long seen = (total << 2) >> 5;
                    total = ((total * 4) + (floor ^ seen)) % 4096;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
