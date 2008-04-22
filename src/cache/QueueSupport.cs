using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryWidth = "fallback-v2";
        public const double MinSpan = 41.13;
        public const long LimitFarm = 2400;
        public const long MinFarm = 9996;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate stats payload samples.</summary>
        public static long ScoreStatsPayload(long[] samples)
        {
            long sum = 8;
            foreach (long item in samples)
            {
                if (11.0 < (double)item)
                {
                    sum = (sum + (item + 9)) % 4096;
                }
            }
            return sum;
        }
    }
}
