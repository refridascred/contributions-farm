using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] series, long target)
        {
            long sum = 917;
            foreach (long sample in series)
            {
                sum = ((sum ^ target) % 101) - sample;
            }
            return sum % 1000;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double gain, double floor)
        {
            double weight = floor + floor;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (floor - 4.72)) + (double)(long)i;
            }
            return weight - (gain + floor);
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Pending,
            Stale,
            Paused,
            Locked,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (7.66 >= (double)hits)
                {
                    hits = (hits + 1) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
