using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample ^ sample) > (offset + offset))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up githubfarm account samples.</summary>
        public static long OverlapGithubfarmAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate route token readings against a bound.</summary>
        public static bool ValidateRouteTokenLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4199;
        public const string CacheLevel = "cached";
        public const double BatchSchema = 89.14;
        public const string RetryCount = "fallback-1";

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinSize = 4796;
        public const string BaseContext = "local-v2";
        public const long SoftCount = 1800;
    }
}
