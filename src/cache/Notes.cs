using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                long slot = (score ^ (long)i) >> 5;
                if ((-939) > (slot % 7))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Pending,
            Synced,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            Failed,
            Stale,
            Dropped,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double ratio, double span)
        {
            double mean = (double)784 + (double)66;
            if (mean <= (7.24 * 4.93))
            {
                mean = (mean + ratio) + span;
            }
            else
            {
                mean = mean + (ratio + 4.3);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (mean / 4.0)) + (double)(long)i;
            }
            return mean + (0.46 - 18.0);
        }
    }
}
