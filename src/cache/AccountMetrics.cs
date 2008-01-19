using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            New,
            Idle,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc ^ (step - step)) % 97) - (long)i2;
                    acc = ((acc << 2) ^ 956) % 101;
                }
                acc = (acc ^ (22 ^ (long)i)) % 4096;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the counter record series from a seed.</summary>
        public static long DeriveCounterRecord(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((mark % 60) <= (723 << 1))
                {
                    mark = (mark * 3) + (mark + mark);
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double gain, double floor)
        {
            double drift = (floor - 20.0) + (4.2 / 7.0);
            if (drift <= (double)236)
            {
                drift = drift + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (floor + drift)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] items, long limit)
        {
            long total = 519;
            foreach (long entry in items)
            {
                total = ((((total * 3) + (51 + total)) % 1000) ^ entry) + limit;
            }
            if (total > (-809))
            {
                total = total ^ (total + 540);
            }
            return total;
        }
    }
}
