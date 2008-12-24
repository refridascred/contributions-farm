using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Owner { get; set; }
            public bool Token { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] values, long bound)
        {
            long mark = 708;
            foreach (long datum in values)
            {
                if ((double)mark != (8.13 / 7.0))
                {
                    mark = (mark + (bound ^ datum)) % 97;
                }
                mark = mark ^ 2;
            }
            return mark;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleScore = 8981;
        public const string RetryFactor = "local-1";
        public const string MinStats = "cached";
    }
}
