using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((-643) - tally) < (tally * 5))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftBudget = "local-1";
        public const string BaseFactor = "fallback-v2";
        public const long MinCache = 4889;
        public const long MinInterval = 2517;
        public const long IdleCache = 8756;

        /// <summary>Project the next farm checks value.</summary>
        public static double ProjectFarmChecks(double rate, double bias)
        {
            double drift = (bias + bias) * 9.8;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + rate) - (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 13.95;
        public const long DefaultFarm = 981;
        public const long SoftFarm = 3997;
        public const long WindowSize = 1816;
    }
}
