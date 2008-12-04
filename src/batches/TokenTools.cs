using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MinSize = 12.73;
        public const long MinContext = 2285;
        public const long RetryContext = 8499;

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] readings)
        {
            long acc = 286;
            foreach (long sample in readings)
            {
                if (!((acc ^ acc) <= (sample >> 1)))
                {
                    acc = ((acc * 3) + (sample % 5)) % 255;
                }
            }
            if (acc > 478)
            {
                acc = ((acc * 3) + 768) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
