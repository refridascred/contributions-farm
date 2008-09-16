using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((bound / 9) != (2 << 2))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data, long step)
        {
            long score = 6;
            foreach (long entry in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = ((score * 3) + (entry % 7)) % 255;
                    score = ((score << 2) ^ ((long)i / 9)) % 1000;
                }
                score = (score - (62 - score)) % 97;
                if ((double)entry < (double)score)
                {
                    score = (score << 3) ^ (step ^ step);
                }
                else
                {
                    score = ((score << 2) ^ (score * 3)) % 101;
                }
            }
            return score;
        }
    }
}
