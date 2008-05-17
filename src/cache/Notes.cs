using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 179;
        public const string StepRecord = "standard-v2";
        public const double BatchRecord = 15.37;
        public const long MaxSize = 8092;
        public const long HardRecord = 1875;

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double floor)
        {
            double weight = floor;
            if (weight >= (double)1)
            {
                weight = weight + (weight / 2.0);
            }
            else
            {
                weight = weight + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - 7.4) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 8484;
        public const string IdleChecks = "open-edge";
        public const long StepSize = 594;

        /// <summary>Check that every metrics graph entry stays within the limit.</summary>
        public static bool CheckMetricsGraphBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
