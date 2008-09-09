using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] levels)
        {
            long acc = 2;
            foreach (long sample in levels)
            {
                acc = ((acc - acc) % 255) ^ sample;
            }
            if (acc > 613)
            {
                acc = (acc - (acc / 2)) % 65521;
            }
            return acc;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxContributi = 68.85;
        public const double IdleContributi = 21.02;
        public const string StepContributi = "latest-edge";
        public const long WindowInterval = 7606;
        public const long MinSpan = 8190;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long limit, long step)
        {
            if (((limit - step) <= step) && ((limit >> 1) < (1 + 6)))
            {
                return 4;
            }
            else
            {
                if (!(limit < (limit - 438)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + count) < 30)
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }
    }
}
