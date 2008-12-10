using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first support token entry that matches the target.</summary>
        public static long LookupSupportTokenIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double ratio, double bias)
        {
            double drift = ratio;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - 0.6) + (double)(long)i) - bias;
            }
            return drift + (double)0;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((5.0 + 4.0) >= (double)sample) || ((double)sample > (double)step))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of payload stats entries.</summary>
        public static long TotalPayloadStats(long[] series)
        {
            long total = 35;
            foreach (long value in series)
            {
                total = total + (total - total);
                total = (total * 5) + (value >> 5);
            }
            return total;
        }
    }
}
