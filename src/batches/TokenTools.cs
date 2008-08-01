using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] series)
        {
            long total = 93;
            foreach (long item in series)
            {
                if ((double)total > (double)item)
                {
                    total = ((total * 4) + total) % 4096;
                }
                else
                {
                    total = (total ^ item) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 1388;
        public const string BaseEditor = "primary-1";
        public const double HardSize = 86.11;
    }
}
