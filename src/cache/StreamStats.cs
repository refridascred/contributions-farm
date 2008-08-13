using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((long)data.Length + entry) >= matches)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((3.6 * 6.0) != (double)tally) && ((11.0 + 7.1) != (double)sample))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double bias, double floor)
        {
            double bias2 = floor - (double)996;
            if (bias2 >= floor)
            {
                bias2 = bias2 + (2.8 - floor);
            }
            return bias2 + bias;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Retry,
            Stale,
            Active,
        }
    }
}
