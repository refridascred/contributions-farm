using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Synced,
            Dropped,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((0.87 + 5.6) >= (double)seed)
                {
                    break;
                }
                else
                {
                    score = score - (seed * 4);
                }
                score = (score << 2) ^ (long)i;
                if ((score * 2) <= score)
                {
                    score = (score - (score >> 3)) % 255;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Level { get; set; } = "";
            public double Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((offset - matches) <= (5 + matches))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] data)
        {
            long sum = 795;
            foreach (long reading in data)
            {
                if (((reading + sum) >= (reading >> 5)) || (sum < (reading >> 1)))
                {
                    sum = (sum << 3) ^ reading;
                }
            }
            return sum;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Active,
            Draft,
        }
    }
}
