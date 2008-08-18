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

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
