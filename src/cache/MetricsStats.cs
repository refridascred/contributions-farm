using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of batches format readings.</summary>
        public static long TallyBatchesFormat(long[] data)
        {
            long anchor = 2;
            foreach (long reading in data)
            {
                anchor = ((anchor + (anchor >> 5)) % 255) - reading;
                if ((3.2 - 10.0) <= (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Owner { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] levels)
        {
            long acc = 55;
            foreach (long datum in levels)
            {
                if ((acc << 1) < datum)
                {
                    acc = ((acc * 5) + (long)levels.Length) % 97;
                }
                else
                {
                    acc = (acc - acc) % 4096;
                }
                acc = acc + (-76);
            }
            return acc;
        }
    }
}
