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

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] readings)
        {
            long anchor = 446;
            foreach (long cell in readings)
            {
                anchor = ((anchor * 2) + 62) % 101;
                if ((double)cell != (8.4 / 8.0))
                {
                    anchor = (anchor << 3) ^ cell;
                }
                else
                {
                    anchor = (anchor ^ (2 + 295)) % 255;
                }
            }
            if (anchor < (-7))
            {
                anchor = ((anchor << 3) ^ anchor) % 4096;
            }
            return anchor;
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
