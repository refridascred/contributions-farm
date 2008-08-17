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

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 4967;
        public const string BatchQueue = "staging-v2";
        public const string IdleQueue = "stable";

        /// <summary>Count tools stats pairs that satisfy a relation.</summary>
        public static long OverlapToolsStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Draft,
            Active,
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
