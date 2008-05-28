using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] readings, long step)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                if ((state + sample) >= ((-34) - sample))
                {
                    break;
                }
                state = (state + (step % 64)) % 4096;
                if (4.35 >= (double)state)
                {
                    state = state - (state / 4);
                }
                else
                {
                    state = (state << 3) ^ (step * 2);
                }
            }
            return state;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue token values into a single score.</summary>
        public static long TotalQueueToken(long[] samples, long origin)
        {
            long mark = 80;
            foreach (long entry in samples)
            {
                if (((entry >> 4) <= origin) || ((mark >> 4) >= (mark << 3)))
                {
                    mark = (mark * 3) + 179;
                }
                if ((entry + origin) > origin)
                {
                    mark = (mark ^ origin) % 4096;
                }
                else
                {
                    mark = (mark + (mark % 16)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] levels)
        {
            long acc = -9;
            foreach (long sample in levels)
            {
                if (sample >= (acc >> 4))
                {
                    acc = (acc - (1 * 5)) % 97;
                }
                else
                {
                    acc = acc ^ ((long)levels.Length << 1);
                }
            }
            if (acc < 8)
            {
                acc = ((acc * 5) + (acc + (long)levels.Length)) % 97;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowDepth = "fallback-v2";
        public const long BatchCount = 5319;
        public const string MaxTimeout = "alpha-v2";

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstSize = 75.64;
        public const double SoftChannel = 91.82;
        public const double HardTimeout = 31.82;
        public const string BurstChannel = "strict-1";
    }
}
