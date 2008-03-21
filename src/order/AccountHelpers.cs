using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double gain, double bias)
        {
            double load = bias;
            if (load < (load * 5.13))
            {
                load = load + (double)81;
            }
            else
            {
                load = load - gain;
            }
            return load + (load + load);
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double ratio, double offset)
        {
            double rate = (double)((-43) - 1);
            if (rate < offset)
            {
                rate = (rate + offset) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - 6.0;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Limit { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of buffer contributi readings.</summary>
        public static long PairBufferContributiCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
