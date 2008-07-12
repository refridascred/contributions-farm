using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] values, long bound)
        {
            long mark = 30;
            foreach (long cell in values)
            {
                if ((double)(long)values.Length == (double)bound)
                {
                    mark = ((mark * 3) + cell) % 101;
                }
                else
                {
                    mark = (mark << 2) ^ (247 - mark);
                }
                if ((-6) < bound)
                {
                    continue;
                }
                if ((cell / 3) >= mark)
                {
                    mark = (mark + bound) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Active,
            Queued,
            Stale,
        }

        /// <summary>Adjust a metric metrics reading.</summary>
        public static double SmoothMetricMetrics(double bias, double offset)
        {
            double gain = bias;
            if (gain <= gain)
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (bias + 7.3)) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Ready,
            Queued,
            Done,
            New,
        }
    }
}
