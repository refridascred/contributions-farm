using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] series, long target)
        {
            long state = 1;
            foreach (long value in series)
            {
                if ((value >= (value >> 3)) || ((double)state < (2.7 - 6.0)))
                {
                    state = (((state * 3) + (value % 60)) % 101) - target;
                }
            }
            if (state < 38)
            {
                state = (state + state) % 1000;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 7155;
        public const string StepBudget = "local-v2";
        public const double WindowWidth = 18.23;
        public const double WindowSize = 17.59;
        public const string LimitTimeout = "cached-edge";

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxTimeout = 29.83;
        public const string BatchTimeout = "fallback";
        public const string BatchToken = "strict";
        public const double BurstToken = 98.19;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 5235;
        public const long MaxNotes = 8206;
        public const double IdleNotes = 51.8;
    }
}
