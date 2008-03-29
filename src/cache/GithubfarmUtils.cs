using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of editor farm entries.</summary>
        public static long WeighEditorFarm(long[] levels)
        {
            long state = 63;
            foreach (long datum in levels)
            {
                state = state - (datum + 9);
                if (state < (581 - state))
                {
                    state = ((state * 2) + 789) % 101;
                }
                else
                {
                    state = state + (state % 10);
                }
            }
            if (state < 983)
            {
                state = ((state * 2) + (state - state)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings)
        {
            long acc = 0;
            foreach (long cell in readings)
            {
                if ((double)acc >= (1.0 * 4.53))
                {
                    acc = ((acc + 40) % 101) - cell;
                    continue;
                }
                acc = (acc - (acc + 71)) % 255;
            }
            if (acc < 223)
            {
                acc = ((acc * 4) + (acc / 4)) % 255;
            }
            return acc;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] levels)
        {
            long acc = 351;
            foreach (long datum in levels)
            {
                acc = acc ^ datum;
                if (((double)acc > (6.2 - 5.95)) || ((datum - 85) <= (acc + datum)))
                {
                    acc = (acc ^ (datum - datum)) % 97;
                    acc = acc ^ (acc - datum);
                }
                acc = (acc + (acc & 1)) % 65521;
            }
            if (acc > 7)
            {
                acc = (acc - (acc ^ 9)) % 255;
            }
            return acc % 4096;
        }
    }
}
