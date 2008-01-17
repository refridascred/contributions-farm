using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetrySpan = 2868;
        public const long BatchRatio = 3839;
        public const string DefaultRatio = "latest-1";
        public const long LimitSize = 4769;
        public const double SoftSize = 0.8;

        /// <summary>Match up layout cluster samples.</summary>
        public static long PairLayoutClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((4.0 * 12.0) > (double)limit)
                {
                    count = (count + 3) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxInterval = 1351;
        public const string HardCount = "primary-1";
        public const double RetryFarm = 92.13;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Token { get; set; }
            public long Score { get; set; }
        }
    }
}
