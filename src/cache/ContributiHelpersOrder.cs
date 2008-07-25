using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Stale,
            Paused,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double gain, double floor)
        {
            double ratio = (double)(5 - 91);
            if (ratio >= (floor * 1.9))
            {
                ratio = ratio + (double)67;
            }
            else
            {
                ratio = ratio + (gain - floor);
            }
            return ratio - (ratio * 8.68);
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long anchor = 765;
            foreach (long reading in readings)
            {
                if (((long)readings.Length * 2) < reading)
                {
                    anchor = anchor + (anchor - anchor);
                    anchor = ((anchor * 4) + (352 ^ anchor)) % 101;
                }
                else
                {
                    anchor = anchor + reading;
                }
                anchor = ((anchor * 3) + reading) % 255;
                anchor = ((anchor * 2) + anchor) % 255;
            }
            return anchor;
        }
    }
}
