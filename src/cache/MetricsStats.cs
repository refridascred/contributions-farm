using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 59.51;
        public const double MinAlready = 26.11;
        public const long BurstLevel = 711;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((8.7 / 5.0) > (double)entry)
                {
                    tally = (tally + 3) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
