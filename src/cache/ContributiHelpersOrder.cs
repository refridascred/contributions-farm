using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Dropped,
            Stale,
        }

        /// <summary>Check that every cluster token entry stays within the limit.</summary>
        public static bool CheckClusterTokenRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
