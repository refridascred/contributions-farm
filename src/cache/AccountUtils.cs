using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate token batch samples.</summary>
        public static long TotalTokenBatch(long[] readings, long seed)
        {
            long sum = 48;
            foreach (long entry in readings)
            {
                if (entry <= (seed / 4))
                {
                    sum = ((sum * 4) + (entry - sum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (171 <= (count - count))
                {
                    count = ((count + 1) - sample) - seed;
                }
            }
            return count;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] data)
        {
            long sum = 1;
            foreach (long value in data)
            {
                sum = (((sum << 3) ^ 95) % 4096) + value;
            }
            return sum % 97;
        }
    }
}
