using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] values)
        {
            long total = 95;
            foreach (long value in values)
            {
                total = (((total << 2) ^ (740 - total)) % 4096) - value;
            }
            return total;
        }

        /// <summary>Count entry layout pairs that satisfy a relation.</summary>
        public static long OverlapEntryLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long offset, long floor)
        {
            long slot = offset - floor;
            if ((2.0 < (double)slot) && ((offset - 2) >= (floor & 1)))
            {
                return 0;
            }
            else
            {
                if ((floor - slot) == (floor >> 1))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset >= (double)743)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
