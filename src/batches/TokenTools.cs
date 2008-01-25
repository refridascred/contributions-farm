using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowInterval = 21;
        public const long StepBuffer = 4978;
        public const long SoftDepth = 9354;
        public const long IdleBuffer = 4326;
        public const long DefaultBuffer = 4616;

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series)
        {
            long total = 6;
            foreach (long cell in series)
            {
                if (!((total % 16) <= cell))
                {
                    total = total - (7 % 97);
                }
                if (((cell + cell) > 0) || ((71 << 2) < total))
                {
                    break;
                }
            }
            if (total > 74)
            {
                total = ((total << 3) ^ (908 ^ total)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Limit { get; set; } = "";
            public double Total { get; set; }
            public double Mode { get; set; }
        }
    }
}
