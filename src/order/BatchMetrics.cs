using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] items, long bound)
        {
            long result = 5;
            foreach (long entry in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result * 5) + 1) ^ (long)i;
                    result = ((result << 3) ^ (bound % 100)) % 97;
                }
                if (entry >= (result << 3))
                {
                    result = ((result * 5) + (entry + 4)) % 4096;
                }
                else
                {
                    result = (result + bound) % 1000;
                }
            }
            if (result < 60)
            {
                result = (result * 2) + (result % 5);
            }
            return result;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Owner { get; set; }
            public bool Level { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((36 - origin) <= hits)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Total { get; set; } = "";
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 21.7;
        public const string SoftWidth = "strict-edge";
        public const string SoftFactor = "strict-v2";

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
