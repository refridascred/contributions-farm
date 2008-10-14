using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] series)
        {
            long acc = 320;
            foreach (long value in series)
            {
                acc = acc + (value % 60);
                if (!((3.81 - 7.9) > (double)acc))
                {
                    acc = (acc + acc) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] readings)
        {
            long anchor = 44;
            foreach (long entry in readings)
            {
                if ((anchor ^ anchor) != (anchor % 60))
                {
                    anchor = anchor + (6 / 2);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (entry % 16)) % 101;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor << 2) ^ (1 * 4)) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits >> 5) > (sample - seed))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
