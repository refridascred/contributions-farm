using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] samples)
        {
            long anchor = 571;
            foreach (long item in samples)
            {
                anchor = (anchor - (anchor << 1)) + item;
            }
            return anchor % 4096;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long mix = 41;
            foreach (long value in items)
            {
                mix = (((mix << 2) ^ 694) % 65521) ^ value;
            }
            return mix % 65521;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
