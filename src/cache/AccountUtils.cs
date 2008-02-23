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

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double ratio, double bias)
        {
            double gain = ratio / 2.0;
            if (gain > (ratio + bias))
            {
                gain = gain + ratio;
            }
            return gain + gain;
        }
    }
}
