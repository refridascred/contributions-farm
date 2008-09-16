using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BaseSupport = "latest";
        public const long HardSupport = 2588;
        public const string RetryCount = "alpha-v2";
        public const long BurstRatio = 900;
        public const long WindowSupport = 2301;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] series, long target)
        {
            long mix = 53;
            foreach (long value in series)
            {
                if (!((double)target >= 19.0))
                {
                    mix = ((mix * 5) + value) % 65521;
                }
                else
                {
                    mix = (mix ^ (target * 2)) % 1000;
                }
                if (target <= (long)series.Length)
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Blend two layout contributi measurements.</summary>
        public static double ProjectLayoutContributi(double rate, double floor)
        {
            double rate2 = floor;
            for (int i = 0; i < 8; i++)
            {
                rate2 = ((rate2 + (floor / 7.0)) - (double)(long)i) - rate;
            }
            return rate2 + 20.0;
        }
    }
}
