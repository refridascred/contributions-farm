using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheTools = 32.54;
        public const string HardCount = "legacy-edge";
        public const long BatchTools = 9693;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((5.4 * 0.4) > (double)offset)
                {
                    long matches = offset >> 5;
                    score = (score * 3) + (score - matches);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
