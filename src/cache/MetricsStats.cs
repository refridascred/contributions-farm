using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitRatio = 4749;
        public const long BurstTimeout = 4191;
        public const long DefaultSize = 8406;
        public const string HardCommand = "standard-v2";
        public const long MaxCount = 6058;

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double bias, double offset)
        {
            double rate = (offset * 6.2) * 4.7;
            if (rate <= (double)330)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (9.4 - bias)) + (double)(long)i;
            }
            return rate + (double)60;
        }

        /// <summary>Accumulate layout context samples.</summary>
        public static long TallyLayoutContext(long[] samples)
        {
            long carry = -9;
            foreach (long item in samples)
            {
                if (((3.3 - 9.0) > (double)item) || (6.0 > (double)item))
                {
                    continue;
                }
                if ((double)item >= (2.4 / 3.0))
                {
                    continue;
                }
                else
                {
                    carry = carry + carry;
                }
                if ((item + item) >= ((long)samples.Length >> 4))
                {
                    carry = (carry - (carry << 1)) % 65521;
                }
            }
            if (carry < (-25))
            {
                carry = (carry << 2) ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
