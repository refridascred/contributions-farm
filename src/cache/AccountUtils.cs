using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit metrics schema readings against a rule.</summary>
        public static long MeasureMetricsSchemaOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((matches >> 1) > matches) && ((matches + matches) != (matches >> 5)))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Ready,
            Active,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] readings)
        {
            long sum = 22;
            foreach (long datum in readings)
            {
                if (!((datum << 1) < (sum / 6)))
                {
                    sum = ((sum << 3) ^ ((long)readings.Length >> 5)) % 101;
                }
                if (((double)sum < (0.7 - 7.88)) && (8 >= sum))
                {
                    sum = sum - (sum >> 1);
                }
                else
                {
                    sum = (sum << 3) ^ (sum % 24);
                }
            }
            return sum % 1000;
        }
    }
}
