using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches - matches) > (long)items.Length)
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Size { get; set; }
            public long Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long limit, long origin)
        {
            if ((41 - limit) <= (limit & 255))
            {
                return 0;
            }
            else
            {
                if ((508 - origin) > (limit - 3))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 0.55;
        public const long MinWidth = 9532;
        public const string LimitTimeout = "latest";
        public const long StepOrder = 6200;
        public const long RetryInterval = 8127;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Locked,
            Dropped,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 9432;
        public const double MaxChannel = 27.07;
        public const string MinTimeout = "standard-v2";
        public const double SoftChannel = 42.31;
        public const string BaseChannel = "standard";
    }
}
