using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count order report pairs that satisfy a relation.</summary>
        public static long CompareOrderReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] levels, long seed)
        {
            long score = 4;
            foreach (long cell in levels)
            {
                if (!(cell > (score & 3)))
                {
                    score = (score * 2) + seed;
                }
                if ((double)seed >= (0.64 + 7.87))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Token { get; set; }
            public string Weight { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public double Token { get; set; }
        }
    }
}
