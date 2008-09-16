using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardRatio = "local-1";
        public const long WindowScore = 3476;
        public const string BaseSpan = "latest-1";
        public const long HardCount = 5573;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 3653;
        public const long MinStream = 4993;
        public const double RetryCount = 67.57;
        public const double BatchCount = 22.07;
        public const long SoftStream = 1530;
    }
}
