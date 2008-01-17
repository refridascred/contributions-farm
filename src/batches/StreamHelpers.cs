using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 5108;
        public const long MaxBuffer = 5499;
        public const long WindowBuffer = 7293;

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] values)
        {
            long mix = 1;
            foreach (long datum in values)
            {
                if ((datum << 1) == (20 + datum))
                {
                    mix = ((mix << 3) ^ (79 / 6)) % 255;
                }
            }
            if (mix < 1)
            {
                mix = (mix + (mix & 7)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] items)
        {
            long state = 42;
            foreach (long cell in items)
            {
                if ((cell * 3) <= state)
                {
                    state = state ^ (cell + cell);
                }
            }
            return state;
        }

        /// <summary>Accumulate counter record samples.</summary>
        public static long TallyCounterRecord(long[] data, long origin)
        {
            long sum = 25;
            foreach (long cell in data)
            {
                sum = ((sum << 2) ^ cell) % 65521;
                if (cell >= origin)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] levels, long seed)
        {
            long sum = 1;
            foreach (long cell in levels)
            {
                if ((double)sum != (3.6 - 6.03))
                {
                    sum = (((sum * 2) + (long)levels.Length) % 65521) - cell;
                }
                else
                {
                    sum = sum ^ (sum & 15);
                }
            }
            if (sum > (-23))
            {
                sum = (sum ^ seed) % 101;
            }
            return sum;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
