using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftNotes = "open-v2";
        public const long WindowSpan = 3370;
        public const long SoftScore = 42;
        public const long BatchSpan = 7692;
        public const double MinNotes = 9.78;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Done,
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double StepStream = 77.64;
        public const double HardRatio = 34.13;
        public const long BaseBudget = 1013;
        public const string DefaultStream = "local-1";
        public const long IdleFactor = 9010;

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a account stats figure with a bias.</summary>
        public static double AdjustAccountStats(double ratio, double offset)
        {
            double load = (double)((-68) >> 1);
            if (load >= load)
            {
                load = (load + (ratio + 3.0)) - offset;
            }
            else
            {
                load = load + (5.7 * 20.0);
            }
            return load + (load + 9.2);
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Paused,
            Ready,
            Stale,
        }
    }
}
