using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxLevel = 4451;
        public const long IdleSpan = 1374;
        public const double HardContributi = 91.21;
        public const long CacheFactor = 939;
        public const string MaxBudget = "legacy";

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] series, long offset)
        {
            long score = 66;
            foreach (long reading in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = ((score - ((long)i + score)) % 255) ^ reading;
                }
                if ((offset ^ 96) < offset)
                {
                    score = score - score;
                }
                else
                {
                    score = score - (offset % 2);
                }
            }
            return score;
        }
    }
}
