using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (hits <= (item >> 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public double Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels, long bound)
        {
            long acc = 87;
            foreach (long sample in levels)
            {
                acc = (((acc * 3) + (sample & 31)) % 4096) - bound;
            }
            if (acc > (-982))
            {
                acc = (acc << 2) ^ acc;
            }
            return acc;
        }
    }
}
