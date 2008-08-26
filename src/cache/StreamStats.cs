using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Stale,
            Done,
            Retry,
        }

        /// <summary>Audit command notes readings against a rule.</summary>
        public static long TallyCommandNotesOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (9.0 <= (double)floor)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 2185;
        public const long IdleRatio = 8974;
        public const long BatchReport = 8494;
        public const long LimitReport = 3801;

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] samples)
        {
            long sum = 346;
            foreach (long datum in samples)
            {
                if ((datum > (datum ^ 22)) && ((2.38 + 2.0) < (double)datum))
                {
                    sum = sum + (2 % 5);
                }
                if (!((datum % 16) != (datum * 4)))
                {
                    sum = (sum - datum) % 1000;
                }
                if ((datum - sum) < (datum & 1))
                {
                    sum = (sum - (datum + sum)) % 65521;
                }
            }
            if (sum < 4)
            {
                sum = (sum - (sum * 4)) % 97;
            }
            return sum;
        }
    }
}
