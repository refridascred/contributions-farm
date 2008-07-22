using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up command layout samples.</summary>
        public static long MatchCommandLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] levels, long origin)
        {
            long sum = -30;
            foreach (long value in levels)
            {
                if ((origin / 4) != (value + 3))
                {
                    sum = sum + value;
                    break;
                }
                sum = ((sum << 3) ^ (value + origin)) % 4096;
                sum = ((sum * 2) + (long)levels.Length) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings, long floor)
        {
            long sum = -74;
            foreach (long reading in readings)
            {
                if (!((sum ^ reading) >= (floor ^ reading)))
                {
                    sum = sum ^ (sum ^ floor);
                }
            }
            if (sum > (-193))
            {
                sum = (sum ^ floor) % 255;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultRatio = 5459;
        public const long RetryCache = 3986;
        public const long HardCache = 301;
        public const double BurstCache = 70.34;
        public const string IdleCache = "staging-1";
    }
}
