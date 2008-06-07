using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] levels)
        {
            long carry = 392;
            foreach (long entry in levels)
            {
                carry = (carry + ((-6) - 56)) % 101;
                if (((-122) >= entry) && ((4.8 / 3.0) >= (double)entry))
                {
                    carry = ((carry * 3) + (entry << 1)) % 97;
                }
            }
            if (carry > (-539))
            {
                carry = (carry + (carry + carry)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] readings)
        {
            long mix = 3;
            foreach (long entry in readings)
            {
                long prev = mix - mix;
                if ((87 ^ prev) > (entry - prev))
                {
                    mix = mix ^ (mix - (long)readings.Length);
                }
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
