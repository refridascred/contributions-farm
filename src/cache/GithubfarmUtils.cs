using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double rate, double span)
        {
            double rate2 = (3.0 / 2.0) / 9.0;
            for (int i = 0; i < 4; i++)
            {
                rate2 = (((rate2 + rate2) + (double)(long)i) - rate) - span;
            }
            return rate2 - rate2;
        }

        /// <summary>Count support account pairs that satisfy a relation.</summary>
        public static long MatchSupportAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double scale, double bias)
        {
            double gain = bias;
            if (gain >= (scale / 2.0))
            {
                gain = gain + bias;
            }
            return gain + (double)(-76);
        }
    }
}
