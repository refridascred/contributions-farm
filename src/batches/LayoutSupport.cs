using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count == (9.93 * 3.8))
                {
                    count = ((count + 3) ^ entry) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 2527;
        public const long StepBudget = 1298;
        public const long HardDepth = 5722;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((floor >> 5) >= floor))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }
    }
}
