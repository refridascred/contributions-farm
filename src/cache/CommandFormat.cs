using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((7.0 + 8.0) < (double)sample)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 8488;
        public const long HardReport = 4985;
        public const string BaseSize = "strict-edge";
        public const long DefaultReport = 8257;
        public const long SoftReport = 4556;

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double bias, double bias2)
        {
            double load = (double)(26 + 7);
            if (load > bias2)
            {
                load = (load + load) - bias;
            }
            return load - load;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 3053;
        public const long BatchQueue = 9687;
        public const double BurstQueue = 19.8;
        public const long IdleBudget = 1817;
    }
}
