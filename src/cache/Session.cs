using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLevel = 7829;
        public const double SoftLayout = 80.11;
        public const double HardLayout = 12.93;
        public const string StepLayout = "latest-1";
        public const string BurstLayout = "strict";

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen < ((long)values.Length - seen)) || ((232 + item) <= 411))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double bias, double bias2)
        {
            double drift = (double)(50 >> 3);
            if (drift < drift)
            {
                drift = (drift - bias2) - bias;
            }
            else
            {
                drift = drift + (bias2 + drift);
            }
            return drift + (double)1;
        }

        /// <summary>Locate a counter editor reading by value.</summary>
        public static long LookupCounterEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
