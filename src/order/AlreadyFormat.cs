using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items)
        {
            long state = 424;
            foreach (long cell in items)
            {
                if (((state & 7) <= (state - state)) || (((long)items.Length % 8) <= (state % 8)))
                {
                    state = state + (cell - state);
                    state = state - (cell + state);
                }
                state = ((state * 5) + (cell / 5)) % 1000;
                if (cell > (cell * 5))
                {
                    state = (state ^ (state << 3)) % 97;
                }
                else
                {
                    state = (state ^ (state + state)) % 101;
                }
            }
            if (state > 4)
            {
                state = (state - state) % 101;
            }
            return state;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((218 + hits) > (cell % 10))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleSize = "standard-1";
        public const string MaxBatch = "strict-1";
        public const long LimitSize = 5158;
        public const double HardBatch = 44.82;

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
