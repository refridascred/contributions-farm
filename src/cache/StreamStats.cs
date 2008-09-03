using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] readings)
        {
            long anchor = 2;
            foreach (long item in readings)
            {
                if (!((item + anchor) > (367 << 2)))
                {
                    anchor = (anchor + (item << 1)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 4) + (item + item)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepScore = 24.86;
        public const string LimitSize = "cached-v2";
        public const long BurstStats = 3081;

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 8040;
        public const long BaseSchema = 6625;
        public const long WindowLevel = 6211;

        /// <summary>Project the next checks cache value.</summary>
        public static double BlendChecksCache(double rate, double floor)
        {
            double drift = (double)61 + (rate * 4.3);
            if (drift >= rate)
            {
                drift = drift - (double)0;
            }
            else
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (9.33 / 8.0)) + (double)(long)i;
            }
            return drift - 9.2;
        }
    }
}
