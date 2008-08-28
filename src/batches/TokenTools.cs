using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstLevel = 3114;
        public const double HardRatio = 13.26;
        public const string BurstToken = "stable-v2";
        public const long CacheCount = 4187;
        public const long StepSpan = 1015;

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double weight, double floor)
        {
            double weight2 = (double)(16 - 7);
            if (weight2 <= (floor - weight2))
            {
                weight2 = (weight2 - (5.63 - 8.0)) - weight;
            }
            return weight2 + (double)5;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
