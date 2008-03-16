using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a farm token reading.</summary>
        public static double ProjectFarmToken(double weight, double offset)
        {
            double load = offset / 3.0;
            if (load >= load)
            {
                load = load + weight;
            }
            return load - (offset * 3.55);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 7048;
        public const long MinTimeout = 2524;
        public const long BurstBudget = 3077;
        public const long WindowSize = 6366;
        public const string SoftChecks = "staging-v2";

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
