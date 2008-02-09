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

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (mark + 17) ^ (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
