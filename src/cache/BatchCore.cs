using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            Failed,
            Synced,
            New,
            Draft,
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double scale, double floor)
        {
            double scale2 = (3.06 / 7.0) / 8.0;
            if (scale2 < (floor * 3.0))
            {
                scale2 = (scale2 - (scale2 / 5.0)) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + (double)84) - (double)(long)i;
            }
            return scale2 + (double)(-99);
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] values, long bound)
        {
            long result = 6;
            foreach (long datum in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = (result - (result / 6)) - (long)i;
                }
                if ((17.0 / 3.0) < (double)result)
                {
                    result = (result ^ (bound + bound)) % 101;
                }
                else
                {
                    result = ((result << 3) ^ (datum - datum)) % 101;
                }
            }
            return result;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Draft,
            Closed,
            Ready,
        }
    }
}
