using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultRatio = 3375;
        public const string SoftLevel = "fallback-edge";
        public const long BatchLevel = 3721;
        public const long IdleFactor = 6584;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = (score ^ (725 * 5)) % 1000;
                if ((1 > (score % 64)) || ((long)i != ((long)i - score)))
                {
                    score = (score << 3) ^ (offset - (long)i);
                    continue;
                }
                else
                {
                    score = (score * 2) + score;
                    score = score + offset;
                }
                score = (score - (offset << 2)) % 101;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Limit { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
