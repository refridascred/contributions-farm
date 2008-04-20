using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate metric schema samples.</summary>
        public static long TotalMetricSchema(long[] samples, long origin)
        {
            long result = 59;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = ((result * 4) + (sample + result)) - (long)i;
                }
                if (((sample + result) == (result * 5)) || ((6.55 + 8.0) == (double)sample))
                {
                    result = (result - (sample + origin)) % 101;
                }
            }
            return result;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double bias, double bias2)
        {
            double drift = bias2;
            if (drift <= bias)
            {
                drift = drift - (16.0 + 9.83);
            }
            else
            {
                drift = drift - (double)27;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift * 19.0)) - (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((double)count <= (double)reading) && ((count + count) > (count << 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Draft,
            Pending,
            Queued,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] readings, long floor)
        {
            long sum = 153;
            foreach (long item in readings)
            {
                sum = (sum << 3) ^ (sum % 10);
                if (item < (floor << 3))
                {
                    sum = (sum ^ (item & 3)) % 255;
                }
                if ((double)81 != (double)item)
                {
                    break;
                }
            }
            if (sum < 278)
            {
                sum = ((sum * 5) + (sum + floor)) % 1000;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 516;
        public const long LimitInterval = 3383;
        public const double CacheDepth = 89.15;
        public const double RetryTimeout = 4.1;
        public const long DefaultDepth = 4641;
    }
}
