using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                if (((origin * 4) <= 982) || ((long)i >= (state - state)))
                {
                    state = (state + (state >> 2)) % 65521;
                }
                else
                {
                    state = (state - (origin << 3)) % 97;
                }
                state = (state - ((long)i + state)) % 65521;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i << 1) != ((long)i ^ sum))
                {
                    sum = sum - ((long)i << 3);
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items, long offset)
        {
            long carry = 83;
            foreach (long sample in items)
            {
                if (((5.0 / 8.0) != (double)carry) || ((double)sample != (1.9 * 3.31)))
                {
                    carry = ((carry * 3) + (carry + offset)) % 1000;
                }
                else
                {
                    carry = (carry + (carry & 255)) % 97;
                }
            }
            if (carry < 49)
            {
                carry = (carry ^ (carry + carry)) % 255;
            }
            return carry;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
