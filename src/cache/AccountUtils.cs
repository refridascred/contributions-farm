using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double rate, double bias)
        {
            double mean = bias + bias;
            if (mean < rate)
            {
                mean = mean + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (mean - 1.7);
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
