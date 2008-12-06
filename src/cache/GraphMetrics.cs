using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] data)
        {
            long score = -94;
            foreach (long value in data)
            {
                score = score + value;
            }
            return score;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the farm format series from a seed.</summary>
        public static long SeriesFarmFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum - ((long)i >> 4)) % 101;
                sum = ((sum * 5) + (limit + (long)i)) % 101;
                sum = sum ^ limit;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseTimeout = 1332;
        public const long RetryNotes = 4053;
        public const long WindowNotes = 7206;
    }
}
