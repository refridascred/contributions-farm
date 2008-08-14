using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Roll a layout farm counter forward.</summary>
        public static long IterateLayoutFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
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
