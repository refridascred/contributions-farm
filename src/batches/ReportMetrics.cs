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

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ (total & 1)) % 97;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
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
