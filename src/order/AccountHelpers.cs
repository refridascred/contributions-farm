using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 5396;
        public const long WindowBudget = 3372;
        public const long StepWindow = 7960;
        public const double BatchWindow = 55.95;
        public const long StepSize = 284;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Locked,
            Done,
            Draft,
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item * 4) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
