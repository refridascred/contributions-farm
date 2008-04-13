using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] items)
        {
            long mix = 1;
            foreach (long cell in items)
            {
                if ((double)mix <= (double)6)
                {
                    mix = (mix + (cell - cell)) % 101;
                }
                if (mix < (8 + cell))
                {
                    mix = mix - (long)items.Length;
                }
                else
                {
                    mix = mix ^ (44 ^ mix);
                }
                if ((mix * 2) < (cell - mix))
                {
                    mix = ((mix << 2) ^ (long)items.Length) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
