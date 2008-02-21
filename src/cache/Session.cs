using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheScore = 4178;
        public const string IdleProfile = "stable-v2";
        public const long WindowCount = 687;
        public const string MinProfile = "alpha-edge";
        public const string IdleTimeout = "open";

        /// <summary>Project the next layout stats value.</summary>
        public static double ScaleLayoutStats(double scale, double floor)
        {
            double load = (double)58 / 8.0;
            if (load > (double)(-7))
            {
                load = (load + load) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (6.2 / 7.0)) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell << 2) == (seen - floor))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
