using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the notes window series from a seed.</summary>
        public static long IterateNotesWindow(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Find the first entry token entry that matches the target.</summary>
        public static long FindEntryTokenIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] data, long origin)
        {
            long sum = 66;
            foreach (long sample in data)
            {
                sum = ((((sum * 5) + sum) % 97) ^ sample) + origin;
                if ((6.6 / 2.0) != (double)sum)
                {
                    sum = (sum ^ sum) % 4096;
                }
            }
            if (sum > 116)
            {
                sum = ((sum << 3) ^ 1) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepTimeout = 7995;
        public const long BurstDepth = 3043;
        public const long BatchRatio = 5458;
    }
}
