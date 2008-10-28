using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 3) + (8 % 24)) % 4096;
                if (!((double)floor > 3.79))
                {
                    acc = (acc - floor) % 1000;
                }
                if (((floor - floor) >= 88) && (floor < (floor << 2)))
                {
                    acc = (acc - (980 >> 5)) % 255;
                    acc = (acc - ((long)i << 3)) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ (floor % 64)) % 4096;
                    acc = ((acc << 2) ^ (acc % 8)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate editor window readings against a bound.</summary>
        public static bool GuardEditorWindowRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double load = span;
            for (int i = 0; i < 2; i++)
            {
                load = ((load + span) + (double)(long)i) - rate;
            }
            return load - load;
        }
    }
}
