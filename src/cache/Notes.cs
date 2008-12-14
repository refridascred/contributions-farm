using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 408;
        public const long BatchCount = 2296;
        public const long HardDepth = 9581;
        public const long HardQueue = 5051;
        public const double BurstQueue = 58.73;

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftDepth = 42.58;
        public const double LimitCounter = 57.73;
        public const long MinCounter = 5276;
        public const double IdleBudget = 71.41;
        public const double WindowCounter = 53.09;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seed * 4) <= (seed + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double drift = offset;
            if (drift < (double)94)
            {
                drift = drift + (double)84;
            }
            return drift - weight;
        }
    }
}
