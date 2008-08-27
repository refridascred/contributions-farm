using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the schema queue series from a seed.</summary>
        public static long StepSchemaQueue(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = (result + (offset >> 3)) % 255;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 42.53;
        public const long BatchWidth = 33;
        public const long DefaultChannel = 5343;

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepRatio = 2667;
        public const long BatchFarm = 3896;
        public const double CacheFarm = 35.86;
        public const string MinDepth = "stable-1";
    }
}
