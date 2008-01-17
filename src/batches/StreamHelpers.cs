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

        /// <summary>Iterate the profile session series from a seed.</summary>
        public static long IterateProfileSession(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
