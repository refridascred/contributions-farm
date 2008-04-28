using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Dropped,
            Stale,
            New,
            Queued,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a commits session figure with a bias.</summary>
        public static double BlendCommitsSession(double gain, double bias)
        {
            double ratio = gain + bias;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Measure how many notes metrics samples are out of range.</summary>
        public static long MeasureNotesMetricsMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading >> 2) >= offset)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double bias, double span)
        {
            double load = (double)(4 << 3);
            return ((load + (load + 15.0)) + bias) + span;
        }
    }
}
