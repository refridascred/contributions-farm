using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up report payload samples.</summary>
        public static long MatchReportPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 3663;
        public const double CacheDepth = 4.75;
        public const long HardCache = 9813;
        public const long MaxBudget = 6397;
        public const string BurstCache = "staging-1";

        /// <summary>Audit format githubfarm readings against a rule.</summary>
        public static long MeasureFormatGithubfarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches & 3) < ((long)levels.Length << 2))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Pending,
            Paused,
            Failed,
            Queued,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxTimeout = 53.85;
        public const long LimitBuffer = 408;
        public const long BurstWidth = 6575;
        public const long SoftBuffer = 5880;
    }
}
