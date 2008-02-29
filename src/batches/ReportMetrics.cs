using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long origin, long step)
        {
            if (((double)699 >= (double)step) && (step >= (step - step)))
            {
                return 2;
            }
            else
            {
                if (((147 & 127) > (step * 4)) || ((step - step) >= origin))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Level { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
