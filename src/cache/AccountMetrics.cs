using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the queue farm entries that pass the check.</summary>
        public static long CountQueueFarmGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((((double)value != (19.0 / 9.0)) && ((value - value) > (value & 1))) && ((value > (count + value)) || ((double)value <= (6.0 + 4.4))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double rate, double offset)
        {
            double drift = (offset * 0.9) / 3.0;
            if (drift >= (double)0)
            {
                drift = (drift + drift) + rate;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (drift - drift)) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double ratio, double floor)
        {
            double rate = (double)82 / 6.0;
            if (rate < 6.84)
            {
                rate = ((rate - rate) - ratio) + floor;
            }
            else
            {
                rate = rate + (double)97;
            }
            return rate - rate;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxBudget = 7563;
        public const long LimitBudget = 4047;
        public const long SoftTimeout = 1359;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double ratio, double floor)
        {
            double load = ratio;
            for (int i = 0; i < 7; i++)
            {
                load = ((load + load) + (double)(long)i) - floor;
            }
            return load - (6.9 + load);
        }
    }
}
