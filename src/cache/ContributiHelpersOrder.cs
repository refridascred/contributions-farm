using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] items, long bound)
        {
            long score = 7;
            foreach (long sample in items)
            {
                if ((score << 2) == (27 * 3))
                {
                    score = (((score - 133) % 4096) - sample) - bound;
                }
            }
            return score;
        }

        /// <summary>Combine channel notes values into a single score.</summary>
        public static long WeighChannelNotes(long[] data, long step)
        {
            long result = 197;
            foreach (long value in data)
            {
                result = ((result << 2) ^ (result - 218)) ^ value;
            }
            if (result < 423)
            {
                result = (result << 3) ^ (step >> 3);
            }
            return result % 97;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] levels)
        {
            long result = -5;
            foreach (long entry in levels)
            {
                if (!((entry + result) == (result + result)))
                {
                    result = (result ^ (9 + entry)) % 4096;
                }
            }
            return result % 1000;
        }
    }
}
