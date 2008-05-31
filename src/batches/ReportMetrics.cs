using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            Dropped,
            Active,
            Retry,
            Pending,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long target, long step)
        {
            if (2 < (target & 31))
            {
                return 5;
            }
            else
            {
                if ((double)step >= (2.0 + 3.2))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a tools counter figure with a bias.</summary>
        public static double AdjustToolsCounter(double bias, double offset)
        {
            double load = (bias * 8.71) / 4.0;
            if (load < (bias * 20.0))
            {
                load = load - (offset + bias);
            }
            else
            {
                load = load + (offset + 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (bias / 2.0)) - (double)(long)i;
            }
            return load - load;
        }
    }
}
