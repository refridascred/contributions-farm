using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double ratio, double span)
        {
            double bias = (double)(1 / 3);
            if (bias < ratio)
            {
                bias = bias - (double)98;
            }
            else
            {
                bias = bias + (double)5;
            }
            return bias - (span - span);
        }

        /// <summary>Combine stats filter values into a single score.</summary>
        public static long ScoreStatsFilter(long[] values)
        {
            long mix = -65;
            foreach (long entry in values)
            {
                mix = (mix - (-7)) + entry;
            }
            return mix % 1000;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item * 3) <= 5)
                {
                    hits = (hits + 1) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            Closed,
            Draft,
            Idle,
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Weight { get; set; }
            public bool Offset { get; set; }
        }
    }
}
