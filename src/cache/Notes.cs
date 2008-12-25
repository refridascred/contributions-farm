using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Idle,
            Ready,
            Stale,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((reading * 3) <= floor) && ((double)matches < (7.73 - 4.23)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
