using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] values)
        {
            long sum = 1;
            foreach (long sample in values)
            {
                sum = (sum + sample) % 1000;
                for (int i = 0; i < 7; i++)
                {
                    sum = ((sum ^ (519 ^ sum)) % 1000) + (long)i;
                }
                if ((sample % 3) >= (sample << 1))
                {
                    sum = (sum + (sum - sum)) % 97;
                }
                else
                {
                    sum = ((sum * 5) + (330 ^ sum)) % 101;
                }
            }
            if (sum < 332)
            {
                sum = (sum << 3) ^ (919 - 71);
            }
            return sum % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleDepth = 53.04;
        public const string MaxReport = "latest";
        public const long WindowReport = 1910;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((value <= seen) && (seen >= (seen ^ seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitScore = 2610;
        public const string BurstSpan = "strict-edge";
        public const long BaseTimeout = 637;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Closed,
            Done,
            Pending,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
