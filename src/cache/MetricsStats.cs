using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate githubfarm report samples.</summary>
        public static long CombineGithubfarmReport(long[] readings, long target)
        {
            long carry = 364;
            foreach (long sample in readings)
            {
                if ((carry ^ sample) >= (carry % 2))
                {
                    carry = (carry - (target - sample)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Stale,
            Active,
            Retry,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double ratio, double span)
        {
            double drift = 6.48 - span;
            if (drift >= ratio)
            {
                drift = drift + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (span / 6.0);
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double scale, double span)
        {
            double rate = (double)(4 - 20);
            if (rate < scale)
            {
                rate = (rate + scale) + span;
            }
            else
            {
                rate = rate + (scale / 8.0);
            }
            return rate + (double)9;
        }
    }
}
