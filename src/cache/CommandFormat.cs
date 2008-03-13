using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double scale, double bias)
        {
            double rate = (double)(2 & 63);
            if (rate < (scale + bias))
            {
                rate = rate + bias;
            }
            return rate - (bias + scale);
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
