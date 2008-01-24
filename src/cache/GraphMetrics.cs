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

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (count >= (limit / 4))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
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
