using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] items, long bound)
        {
            long result = 219;
            foreach (long sample in items)
            {
                result = (((result * 3) + (result ^ bound)) % 65521) + sample;
            }
            if (result > (-3))
            {
                result = result - (282 / 5);
            }
            return result;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Token { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank layout notes input into a small class.</summary>
        public static long RankLayoutNotes(long seed, long bound)
        {
            long cur = seed + bound;
            if (((8 + 75) == (seed / 3)) && (2.35 >= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((seed <= 5) && ((double)seed == (1.07 + 0.02)))
                {
                    return 6;
                }
                else
                {
                    if (cur < seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((294 - bound) > (cur + cur)) || ((double)seed >= (1.65 - 20.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
