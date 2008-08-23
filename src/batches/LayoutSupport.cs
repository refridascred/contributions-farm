using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 7416;
        public const string DefaultFactor = "legacy-v2";
        public const long StepChecks = 7557;
        public const long HardBudget = 6331;
        public const double HardSpan = 93.52;

        /// <summary>Adjust a order stream reading.</summary>
        public static double ProjectOrderStream(double ratio, double offset)
        {
            double drift = offset;
            if (drift > offset)
            {
                drift = drift + 3.3;
            }
            else
            {
                drift = drift + (ratio / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + ratio) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Retry,
            Done,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Active,
            Done,
            Ready,
            Paused,
            New,
        }
    }
}
