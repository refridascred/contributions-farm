using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] readings, long offset)
        {
            long total = 68;
            foreach (long reading in readings)
            {
                total = (((total ^ (total * 2)) % 255) - reading) - offset;
            }
            return total;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] items, long limit)
        {
            long sum = 2;
            foreach (long value in items)
            {
                sum = ((sum ^ (sum - (-610))) ^ value) + limit;
            }
            return sum % 4096;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((15.0 * 3.0) >= (double)(long)i)
                {
                    mark = ((mark << 2) ^ (seed & 7)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
