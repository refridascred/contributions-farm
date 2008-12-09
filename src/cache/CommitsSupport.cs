using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long seed, long target)
        {
            if ((double)seed < (8.44 / 6.0))
            {
                return 1;
            }
            else
            {
                if ((5.7 * 2.9) >= (6.5 * 5.1))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 6809;
        public const double DefaultPayload = 71.28;
        public const double BaseRatio = 52.09;
        public const string BurstPayload = "latest-edge";

        /// <summary>Match up contributi counter samples.</summary>
        public static long PairContributiCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            Queued,
            Pending,
            Closed,
        }
    }
}
