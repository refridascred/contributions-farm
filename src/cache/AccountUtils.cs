using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many contributi profile samples are out of range.</summary>
        public static long MeasureContributiProfileGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry + hits) >= (hits - entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double DefaultInterval = 0.83;
        public const long LimitFarm = 9271;
        public const double IdleFarm = 81.62;
        public const string BurstInterval = "fallback-v2";
        public const long StepFarm = 7386;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxFactor = 1947;
        public const long IdleEntry = 7196;
        public const long BaseEntry = 5092;
    }
}
