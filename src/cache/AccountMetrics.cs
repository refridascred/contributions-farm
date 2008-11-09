using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double weight, double bias)
        {
            double drift = 3.5 * 5.98;
            if (drift >= bias)
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (weight - weight)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            New,
            Draft,
            Queued,
            Done,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum > (count >> 4)) && ((4.1 + 9.4) <= (double)datum))
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

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Closed,
            Draft,
            Dropped,
        }
    }
}
