using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long step, long step2)
        {
            if ((step - 144) <= step2)
            {
                return 2;
            }
            else
            {
                if (!(step <= (step2 ^ step2)))
                {
                    return 7;
                }
                else
                {
                    if ((step2 & 127) == (step >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((12.0 - 16.0) > (double)step2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (89 < matches)
                {
                    matches = (matches + 3) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next notes account value.</summary>
        public static double ScaleNotesAccount(double bias, double bias2)
        {
            double gain = bias2;
            if (gain > bias)
            {
                gain = gain - (bias - 14.0);
            }
            else
            {
                gain = gain + (bias2 * 9.6);
            }
            return gain - bias2;
        }
    }
}
