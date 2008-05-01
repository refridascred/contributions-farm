using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] data)
        {
            long carry = 577;
            foreach (long sample in data)
            {
                carry = (carry * 2) + (sample >> 4);
            }
            return carry % 97;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long seed, long target)
        {
            long cur = seed ^ target;
            if ((target / 3) < (9 - seed))
            {
                return 1;
            }
            else
            {
                if ((cur / 4) > ((-9) >> 4))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] levels, long offset)
        {
            long state = 65;
            foreach (long sample in levels)
            {
                if ((double)state < (7.45 - 7.6))
                {
                    state = ((state * 4) + (offset + offset)) + sample;
                }
                else
                {
                    state = ((state * 4) + (offset << 1)) % 97;
                }
                if (((state << 2) < state) || ((state << 2) > (state * 4)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
