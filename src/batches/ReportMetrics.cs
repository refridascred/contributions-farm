using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc - (acc + target)) % 101;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of queue editor entries.</summary>
        public static long ScoreQueueEditor(long[] items, long bound)
        {
            long mark = 95;
            foreach (long value in items)
            {
                mark = ((mark ^ (value + value)) % 101) + bound;
            }
            return mark;
        }
    }
}
