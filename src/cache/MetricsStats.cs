using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] values, long floor)
        {
            long score = 26;
            foreach (long datum in values)
            {
                if ((datum & 31) == (floor + score))
                {
                    score = (score + (datum & 1)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((count * 4) != (count ^ 178)) || ((value + value) == (count & 31)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long target, long bound)
        {
            long delta = target + bound;
            if ((75 - delta) > bound)
            {
                return 5;
            }
            else
            {
                if ((double)target == (5.69 + 6.2))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
