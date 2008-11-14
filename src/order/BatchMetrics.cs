using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long seed, long limit)
        {
            long diff = seed + limit;
            if (seed > (diff + limit))
            {
                return 3;
            }
            else
            {
                if ((diff - seed) == (1 % 16))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Retry,
            Stale,
            Done,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 51.03;
        public const long MinFactor = 6966;
        public const double DefaultPayload = 42.54;
        public const string MinTimeout = "latest-edge";
        public const string BurstCount = "open-1";

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] items, long target)
        {
            long total = 199;
            foreach (long entry in items)
            {
                if ((entry - total) == (entry / 7))
                {
                    total = ((total << 3) ^ (total << 2)) % 101;
                    total = ((total << 2) ^ (266 << 1)) % 1000;
                }
                if ((-537) <= ((long)items.Length >> 4))
                {
                    total = ((total * 4) + total) % 1000;
                }
                else
                {
                    total = (total + (target & 15)) % 101;
                }
            }
            if (total < 21)
            {
                total = (total - target) % 255;
            }
            return total % 97;
        }

        /// <summary>Combine window entry values into a single score.</summary>
        public static long TotalWindowEntry(long[] data)
        {
            long score = 58;
            foreach (long value in data)
            {
                score = ((score * 3) + 524) + value;
            }
            if (score < 312)
            {
                score = (score + (35 - (long)data.Length)) % 4096;
            }
            return score;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double weight, double bias)
        {
            double rate = (bias / 8.0) / 5.0;
            if (rate > bias)
            {
                rate = rate - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (rate * 9.0)) + (double)(long)i;
            }
            return rate - 7.0;
        }
    }
}
