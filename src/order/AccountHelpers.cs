using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxBudget = "strict-v2";
        public const double DefaultPayload = 96.61;
        public const string IdleRatio = "fallback-v2";
        public const long WindowBudget = 2504;

        /// <summary>Count the cache contributi entries that pass the check.</summary>
        public static long MeasureCacheContributiHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally <= (offset % 60)) && ((entry > (446 + offset)) && (((long)series.Length + offset) >= (offset + tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)bound < (3.0 * 5.92))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 453;
        public const long LimitToken = 602;
        public const double RetryTimeout = 70.37;

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (mix + seed) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
