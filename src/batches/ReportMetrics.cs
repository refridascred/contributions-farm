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

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long anchor = 361;
            foreach (long cell in samples)
            {
                anchor = ((anchor * 5) + (cell / 7)) % 1000;
            }
            if (anchor < 4)
            {
                anchor = anchor - anchor;
            }
            return anchor;
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
