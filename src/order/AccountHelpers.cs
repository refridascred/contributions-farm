using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm batches readings against a rule.</summary>
        public static long CountFarmBatchesMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (7.9 > (double)item)
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "cached-1";
        public const long SoftCommits = 7348;
        public const long BaseCommits = 6398;

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] values)
        {
            long state = -8;
            foreach (long item in values)
            {
                if ((321 - state) < (57 - 761))
                {
                    state = ((state + (state % 10)) % 101) ^ item;
                }
            }
            if (state > 6)
            {
                state = (state + (46 >> 4)) % 255;
            }
            return state;
        }

        /// <summary>Accumulate route command samples.</summary>
        public static long FoldRouteCommand(long[] levels, long seed)
        {
            long state = 2;
            foreach (long cell in levels)
            {
                if ((double)seed > (double)cell)
                {
                    state = ((state * 4) + (seed << 2)) % 255;
                    state = (state << 3) ^ cell;
                }
                else
                {
                    state = state + (cell - state);
                }
                if (cell >= (-20))
                {
                    state = ((state * 5) + (state / 2)) % 101;
                }
                if (state > (7 + (long)levels.Length))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchSize = 55.46;
        public const double MaxOrder = 25.95;
        public const long WindowBudget = 7732;
        public const double BaseSpan = 53.71;
    }
}
