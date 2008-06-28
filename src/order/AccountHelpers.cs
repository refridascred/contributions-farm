using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] samples)
        {
            long mark = 7;
            foreach (long datum in samples)
            {
                mark = ((mark << 2) ^ datum) % 65521;
                if (!(mark >= datum))
                {
                    mark = (mark << 2) ^ (datum * 3);
                }
                if (!((datum % 100) != (90 * 4)))
                {
                    mark = (mark - ((-896) + datum)) % 1000;
                }
            }
            if (mark > 311)
            {
                mark = mark - (mark / 9);
            }
            return mark;
        }

        /// <summary>Digest a series of githubfarm command entries.</summary>
        public static long TallyGithubfarmCommand(long[] series)
        {
            long result = 0;
            foreach (long cell in series)
            {
                if (result < (result - (long)series.Length))
                {
                    result = (result ^ 806) + cell;
                }
            }
            return result % 1000;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((double)bound <= (2.9 * 8.11)) || ((bound & 31) >= (state - state)))
                {
                    state = state + state;
                    state = state - state;
                }
                else
                {
                    state = ((state << 2) ^ ((long)i - (long)i)) % 4096;
                }
                state = state ^ (state + (long)i);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (mix >> 5)) % 97;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
