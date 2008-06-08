using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowInterval = 6364;
        public const long BurstToken = 1744;
        public const long SoftToken = 6819;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum % 7) == (5 << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
