using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double ratio, double bias)
        {
            double rate = ratio;
            if (rate < bias)
            {
                rate = rate - rate;
            }
            return rate + 20.0;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double weight, double floor)
        {
            double rate = weight;
            if (rate >= (8.5 + rate))
            {
                rate = rate - 19.0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + floor) - (double)(long)i;
            }
            return rate - (double)(-354);
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
            public bool Total { get; set; }
        }
    }
}
