using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8817;
        public const double MaxTimeout = 57.72;
        public const double BurstDepth = 39.07;
        public const long DefaultScore = 5541;
        public const long MaxReport = 4050;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Closed,
            Failed,
            Retry,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((long)values.Length - tally) != (tally % 16))
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Pending,
            Done,
            New,
            Ready,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCount = "stable-edge";
        public const long LimitFactor = 391;
        public const long HardCommits = 5775;
        public const double LimitCommits = 34.93;

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] samples, long bound)
        {
            long score = 33;
            foreach (long item in samples)
            {
                if (582 > (item - (long)samples.Length))
                {
                    score = score + (bound + bound);
                }
            }
            if (score < 8)
            {
                score = (score - (score << 3)) % 101;
            }
            return score % 65521;
        }
    }
}
