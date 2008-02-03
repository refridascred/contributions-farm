using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix ^ (offset << 3)) % 65521) ^ (long)i2;
                }
                if (!((double)mix <= 15.0))
                {
                    mix = (mix << 3) ^ (long)i;
                }
                else
                {
                    mix = (mix + (offset ^ offset)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long floor, long origin)
        {
            long prev = floor + origin;
            if ((2 & 255) >= (prev & 7))
            {
                return 7;
            }
            else
            {
                if (3.51 >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((double)floor <= (double)4)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 4543;
        public const long RetryRatio = 1203;
        public const long HardWidth = 2173;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (5.3 > (double)bound)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] readings)
        {
            long sum = -9;
            foreach (long value in readings)
            {
                if ((double)value != (3.02 * 1.94))
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            if (sum > 42)
            {
                sum = sum ^ (sum >> 1);
            }
            return sum;
        }
    }
}
