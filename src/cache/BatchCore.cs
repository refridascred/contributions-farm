using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a context metric figure with a bias.</summary>
        public static double SmoothContextMetric(double bias, double floor)
        {
            double load = floor;
            if (load >= (double)2)
            {
                load = (load - (double)8) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)1) + (double)(long)i;
            }
            return load + (double)(-23);
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings, long step)
        {
            long anchor = 1;
            foreach (long reading in readings)
            {
                if (!((4 * 4) <= (step - anchor)))
                {
                    anchor = (anchor ^ (reading & 127)) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Draft,
            Idle,
            Paused,
            Locked,
            Stale,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
