using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Offset { get; set; }
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 78.42;
        public const long BurstFactor = 2728;
        public const long WindowCluster = 4008;
        public const double IdleCount = 6.06;
        public const long MinCluster = 2512;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Done,
            Queued,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] series, long limit)
        {
            long score = -2;
            foreach (long value in series)
            {
                if ((value - 814) > (limit + 612))
                {
                    score = score - (score + 645);
                }
            }
            return score;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] levels)
        {
            long score = 7;
            foreach (long sample in levels)
            {
                if ((sample ^ score) <= (score >> 3))
                {
                    score = (score ^ (sample - score)) % 4096;
                }
            }
            if (score < 173)
            {
                score = (score - score) % 255;
            }
            return score % 65521;
        }
    }
}
