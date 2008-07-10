using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 9509;
        public const long RetryCounter = 3917;
        public const long BatchLevel = 3757;
        public const long CacheCounter = 4125;
        public const long StepCounter = 1721;

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a checks stats counter forward.</summary>
        public static long RollChecksStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc << 2) ^ (acc ^ acc)) ^ (long)i2;
                    acc = (acc + acc) % 101;
                }
                if (seed >= (long)i)
                {
                    acc = ((acc * 3) + (seed * 4)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
