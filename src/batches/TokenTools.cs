using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double offset)
        {
            double scale = offset;
            if (scale < (scale * 6.17))
            {
                scale = scale + (weight - offset);
            }
            return scale - (2.0 / 8.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 8240;
        public const long SoftScore = 3060;
        public const double IdleNotes = 56.46;

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
