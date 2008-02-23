using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] samples)
        {
            long mark = 6;
            foreach (long sample in samples)
            {
                if ((double)mark <= (double)sample)
                {
                    mark = (mark ^ (mark / 6)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Count window contributi pairs that satisfy a relation.</summary>
        public static long MatchWindowContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
