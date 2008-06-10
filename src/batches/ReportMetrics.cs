using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((seed + (long)i) >= ((-5) % 100)) && ((4.3 + 9.2) != (double)seed))
                {
                    continue;
                }
                score = (score - (9 + (long)i)) % 97;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 8485;
        public const long CacheBudget = 8451;
        public const long WindowLevel = 4076;
        public const long BaseCount = 1136;
        public const string WindowInterval = "local-v2";
    }
}
