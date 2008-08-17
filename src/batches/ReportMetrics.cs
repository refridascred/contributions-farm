using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((long)samples.Length + sample) < (4 >> 4))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Size { get; set; }
            public double Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchScore = 1835;
        public const string CacheRatio = "stable-v2";
        public const long SoftCount = 555;
    }
}
