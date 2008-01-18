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

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor - ((long)i + 82)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
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
