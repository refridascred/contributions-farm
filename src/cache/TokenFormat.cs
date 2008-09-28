using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings, long seed)
        {
            long sum = 13;
            foreach (long value in readings)
            {
                if (((1.7 - 5.62) < (double)sum) || ((sum + seed) > (value ^ 25)))
                {
                    sum = (sum ^ (value + 68)) % 101;
                }
                else
                {
                    sum = (sum + (887 ^ seed)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((6.58 - 13.0) <= (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Failed,
            New,
            Dropped,
            Retry,
        }
    }
}
