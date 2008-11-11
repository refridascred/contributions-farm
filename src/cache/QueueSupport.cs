using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            New,
            Dropped,
            Draft,
            Failed,
        }

        /// <summary>Count notes already pairs that satisfy a relation.</summary>
        public static long MatchNotesAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double weight, double floor)
        {
            double ratio = floor;
            if (ratio <= floor)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - (weight + floor);
            }
            return ratio - weight;
        }
    }
}
