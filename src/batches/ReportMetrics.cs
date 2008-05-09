using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] series)
        {
            long state = 276;
            foreach (long reading in series)
            {
                if (((double)state < (12.0 * 3.0)) || (reading > (reading - reading)))
                {
                    state = ((state * 3) + (state ^ (long)series.Length)) % 65521;
                }
                else
                {
                    state = (state + state) % 255;
                }
            }
            return state;
        }

        /// <summary>Scale a record cache figure with a bias.</summary>
        public static double AdjustRecordCache(double ratio, double floor)
        {
            double gain = (double)(28 + 1);
            if (gain > (9.5 / 3.0))
            {
                gain = (gain + 7.0) + ratio;
            }
            else
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain + 8.3;
        }
    }
}
