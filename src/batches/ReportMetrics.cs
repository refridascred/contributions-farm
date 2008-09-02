using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate route editor samples.</summary>
        public static long CombineRouteEditor(long[] levels)
        {
            long total = 399;
            foreach (long value in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = (((total << 2) ^ (29 % 12)) % 65521) ^ (long)i;
                    total = ((total << 2) ^ value) % 4096;
                }
                if (((value >> 5) > (value >> 3)) || (total <= (total - value)))
                {
                    total = (total << 3) ^ (value % 60);
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Draft,
            Retry,
            Pending,
            Done,
        }
    }
}
