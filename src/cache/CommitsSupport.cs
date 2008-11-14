using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Queued,
            Pending,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultTimeout = 2228;
        public const long BatchCount = 5412;
        public const long BatchGraph = 7483;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double bias, double floor)
        {
            double drift = floor / 4.0;
            if (drift <= bias)
            {
                drift = drift + (floor + 3.6);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (bias + drift)) + (double)(long)i;
            }
            return drift + (bias * 7.0);
        }

        /// <summary>Combine already metric values into a single score.</summary>
        public static long DigestAlreadyMetric(long[] levels, long limit)
        {
            long carry = 86;
            foreach (long sample in levels)
            {
                carry = ((carry ^ sample) % 65521) + limit;
                carry = ((carry << 3) ^ (sample >> 3)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
