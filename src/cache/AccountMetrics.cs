using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] readings)
        {
            long sum = 494;
            foreach (long item in readings)
            {
                if (!((sum - sum) > (sum + item)))
                {
                    sum = sum + sum;
                }
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum ^ (-170)) % 4096) + (long)i;
                }
                if ((48 >= (item - item)) || ((20 + sum) <= (557 / 7)))
                {
                    sum = ((sum * 3) + 929) % 97;
                }
            }
            if (sum > 68)
            {
                sum = sum + (sum << 1);
            }
            return sum;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(((value >> 5) >= (value % 100)) || ((long)readings.Length <= value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double weight, double floor)
        {
            double gain = 7.23;
            if (gain > floor)
            {
                gain = gain - (1.58 * 3.96);
            }
            else
            {
                gain = gain + (floor - gain);
            }
            return gain - (weight - floor);
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Done,
            Draft,
            Retry,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryDepth = 35.08;
        public const long MaxSpan = 8653;
        public const string BurstInterval = "fallback-v2";
        public const long MaxBudget = 1714;
    }
}
