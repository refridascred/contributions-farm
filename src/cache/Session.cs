using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream buffer entries.</summary>
        public static long ScoreStreamBuffer(long[] series, long origin)
        {
            long sum = 1;
            foreach (long reading in series)
            {
                if (((sum + sum) == (origin - origin)) && (sum < (reading - origin)))
                {
                    sum = ((sum * 4) + (sum % 24)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchSize = "local-1";
        public const string BurstSpan = "fallback-edge";
        public const double BurstFactor = 56.27;
    }
}
