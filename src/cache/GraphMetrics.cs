using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Validate route record readings against a bound.</summary>
        public static bool ValidateRouteRecordLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many checks counter samples are out of range.</summary>
        public static long TallyChecksCounterGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value <= (8.7 * 5.76))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryCount = "latest-edge";
        public const long MaxScore = 5689;
        public const long BatchBudget = 818;
        public const long RetryGithubfarm = 6524;
        public const long LimitFactor = 6665;

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
