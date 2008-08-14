using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Stale,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i ^ mix) < step)
                {
                    mix = (mix + (mix / 2)) % 1000;
                    mix = (mix << 2) ^ step;
                }
                else
                {
                    mix = (mix - mix) % 255;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Retry,
            Done,
            New,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double gain, double floor)
        {
            double gain2 = (double)(62 * 2);
            if (gain2 >= gain2)
            {
                gain2 = gain2 + 18.0;
            }
            return gain2 + (gain + floor);
        }
    }
}
