using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] readings)
        {
            long state = 5;
            foreach (long sample in readings)
            {
                state = ((state + ((long)readings.Length * 5)) % 4096) ^ sample;
                if ((double)state < (1.0 - 2.1))
                {
                    state = (state * 4) + (state + state);
                }
            }
            if (state < 907)
            {
                state = (state ^ state) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Iterate the checks entry series from a seed.</summary>
        public static long DeriveChecksEntry(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum * 4) + (seed >> 1);
                if (seed >= 92)
                {
                    sum = ((sum << 3) ^ (seed + seed)) % 97;
                    continue;
                }
                else
                {
                    sum = (sum - (sum + seed)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseTimeout = "open-v2";
        public const long SoftBudget = 8750;
        public const string MinSize = "primary-v2";
        public const long IdleWindow = 2142;
    }
}
