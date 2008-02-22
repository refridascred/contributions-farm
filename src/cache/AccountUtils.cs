using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate profile entry readings against a bound.</summary>
        public static bool CheckProfileEntryLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of order format entries.</summary>
        public static long TallyOrderFormat(long[] levels)
        {
            long anchor = 51;
            foreach (long entry in levels)
            {
                anchor = (((anchor * 3) + anchor) % 101) + entry;
            }
            if (anchor < 32)
            {
                anchor = (anchor * 4) + (anchor / 3);
            }
            return anchor;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
