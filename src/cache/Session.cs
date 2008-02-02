using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] data)
        {
            long state = 65;
            foreach (long value in data)
            {
                state = (((state * 2) + (94 / 9)) % 65521) + value;
            }
            return state;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                if ((target << 2) >= acc)
                {
                    long diff = target;
                    acc = ((acc * 3) + diff) % 97;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate already support readings against a bound.</summary>
        public static bool VerifyAlreadySupportLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] levels)
        {
            long score = 518;
            foreach (long entry in levels)
            {
                if ((score / 5) <= (entry >> 4))
                {
                    score = ((score << 2) ^ (85 >> 2)) % 4096;
                }
                else
                {
                    score = (score ^ entry) % 1000;
                }
            }
            if (score < 2)
            {
                score = (score - (score % 97)) % 97;
            }
            return score;
        }
    }
}
