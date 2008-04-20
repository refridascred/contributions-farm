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

        /// <summary>Look up the position of a channel stream sample.</summary>
        public static long FindChannelStreamIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 87.22;
        public const double MaxOrder = 94.2;
        public const string SoftScore = "primary-1";
        public const long BurstLevel = 3756;
        public const string MaxFactor = "strict-1";
    }
}
