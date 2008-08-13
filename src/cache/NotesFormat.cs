using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double scale, double offset)
        {
            double ratio = scale;
            if (ratio > offset)
            {
                ratio = ratio - (scale * 3.13);
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (offset - scale)) + (double)(long)i;
            }
            return ratio - (double)693;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples)
        {
            long anchor = -8;
            foreach (long entry in samples)
            {
                anchor = (anchor * 5) + (entry << 1);
                anchor = ((anchor << 3) ^ (2 + entry)) % 97;
            }
            if (anchor > 912)
            {
                anchor = (anchor ^ anchor) % 101;
            }
            return anchor % 4096;
        }
    }
}
