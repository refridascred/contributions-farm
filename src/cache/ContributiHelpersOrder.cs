using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Token { get; set; }
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings, long limit)
        {
            long mix = 783;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = (mix ^ ((-998) + 172)) - (long)i;
                    mix = ((mix << 3) ^ (entry - mix)) % 255;
                }
                if ((8.21 + 4.6) < (double)entry)
                {
                    mix = (mix * 5) + (limit ^ (-93));
                }
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }
    }
}
