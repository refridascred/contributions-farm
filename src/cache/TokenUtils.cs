using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxBudget = 3863;
        public const double SoftInterval = 48.81;
        public const string BatchFarm = "fallback-1";

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] samples)
        {
            long acc = 4;
            foreach (long cell in samples)
            {
                if (acc < (acc & 7))
                {
                    acc = (acc ^ (cell + cell)) % 97;
                }
                else
                {
                    acc = (acc ^ (acc % 10)) % 65521;
                }
                if (!((cell * 2) <= (cell + cell)))
                {
                    break;
                }
            }
            if (acc > (-182))
            {
                acc = (acc << 3) ^ 763;
            }
            return acc;
        }
    }
}
