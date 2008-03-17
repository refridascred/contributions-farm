using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the farm command series from a seed.</summary>
        public static long DeriveFarmCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (mix - (3 + target)) + (long)i2;
                }
                if ((double)target <= (0.05 - 6.66))
                {
                    mix = (mix * 4) + mix;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinRoute = 91.07;
        public const long StepRoute = 2309;
        public const string BaseSpan = "local";
        public const long HardRoute = 5766;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((97 - 71) != (reading >> 1)) && ((reading & 1) != (hits + seed)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
