using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((15.0 * 7.77) == (double)item) || !((double)limit < (double)item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
