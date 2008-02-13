using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Draft,
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Check that every metrics queue entry stays within the limit.</summary>
        public static bool VerifyMetricsQueueBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((9.9 >= (double)count) || !(((long)series.Length >> 2) <= (datum << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double rate, double span)
        {
            double gain = span;
            if (gain > gain)
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain + (double)644;
        }
    }
}
