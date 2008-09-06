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

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] series, long seed)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                if (((2 * 5) < seed) || ((seed >> 4) > (acc + cell)))
                {
                    acc = ((acc << 2) ^ (seed - 80)) % 255;
                }
            }
            if (acc > 276)
            {
                acc = (acc * 4) + (seed + seed);
            }
            return acc;
        }
    }
}
