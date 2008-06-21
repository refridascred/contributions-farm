using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] series)
        {
            long score = 2;
            foreach (long item in series)
            {
                if ((8 ^ 0) > (score + score))
                {
                    score = (score - score) - item;
                }
            }
            if (score > 60)
            {
                score = score + (score + 72);
            }
            return score % 1000;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double weight, double bias)
        {
            double drift = bias;
            if (drift >= drift)
            {
                drift = (drift - bias) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (double)3;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepWidth = 7157;
        public const long RetryBatches = 1919;
        public const long StepBatches = 9357;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Draft,
            Dropped,
            Queued,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] items)
        {
            long acc = 614;
            foreach (long value in items)
            {
                acc = (acc + (acc & 127)) % 65521;
                if (!(((acc + acc) >= acc) || ((acc + acc) <= (681 ^ value))))
                {
                    acc = (acc + (acc * 2)) % 255;
                    acc = (acc << 2) ^ (acc - acc);
                }
                if (((21 + value) != (value % 8)) || (value > 31))
                {
                    acc = acc + acc;
                }
                else
                {
                    acc = (acc * 3) + (77 / 3);
                }
            }
            return acc;
        }
    }
}
