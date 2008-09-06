using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftWidth = 3381;
        public const long HardBudget = 8208;
        public const long WindowWidth = 4706;

        /// <summary>Derive the next stream editor value from a seed.</summary>
        public static long StepStreamEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor - floor) % 4096;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double floor)
        {
            double scale = (floor + ratio) + (ratio + ratio);
            if (scale > (double)5)
            {
                scale = scale - (double)99;
            }
            return scale + (ratio * 3.8);
        }
    }
}
