using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double weight, double floor)
        {
            double rate = weight;
            if (rate >= rate)
            {
                rate = (rate - 4.8) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (weight * 3.8)) + (double)(long)i;
            }
            return rate - (double)6;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] samples, long origin)
        {
            long state = 89;
            foreach (long sample in samples)
            {
                state = ((state * 2) + (sample + origin)) % 101;
            }
            if (state < 9)
            {
                state = state ^ (state + state);
            }
            return state % 1000;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + 11) >= 424)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Draft,
            Active,
            Pending,
        }
    }
}
