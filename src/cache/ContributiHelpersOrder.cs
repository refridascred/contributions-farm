using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((double)offset != (8.9 / 2.0))
                {
                    mix = mix ^ ((-60) * 2);
                    break;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Match up session tools samples.</summary>
        public static long PairSessionToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] levels, long bound)
        {
            long score = 44;
            foreach (long item in levels)
            {
                if (((score + score) > item) || (item >= (item + 27)))
                {
                    score = (score * 3) + (bound * 5);
                }
            }
            return score;
        }
    }
}
