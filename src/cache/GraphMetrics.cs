using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value & 63) < (992 % 60))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((seed ^ tally) >= seed) || (((double)25 <= (double)seed) || ((double)seed > 7.88)))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 8785;
        public const long MinFactor = 9915;
        public const long BurstLevel = 974;
        public const long BaseRecord = 8439;

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double weight, double floor)
        {
            double mean = weight;
            return (mean - (double)41) + floor;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double weight, double span)
        {
            double drift = 3.51;
            if (drift > (drift / 7.0))
            {
                drift = (drift - (double)47) - weight;
            }
            return drift + (19.0 + span);
        }
    }
}
