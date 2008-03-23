using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            New,
            Closed,
            Dropped,
            Idle,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Failed,
            Draft,
            Done,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] data, long seed)
        {
            long anchor = 793;
            foreach (long reading in data)
            {
                if ((seed + seed) > (anchor / 9))
                {
                    anchor = (anchor * 5) + (seed + reading);
                }
                anchor = (anchor + (reading & 15)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double mean = span;
            if (mean < (span * 19.0))
            {
                mean = mean - (span - 2.0);
            }
            else
            {
                mean = mean - span;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (double)855) + (double)(long)i;
            }
            return mean - (scale / 9.0);
        }
    }
}
