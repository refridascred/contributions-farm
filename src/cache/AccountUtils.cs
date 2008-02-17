using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of window record entries.</summary>
        public static long DigestWindowRecord(long[] series, long bound)
        {
            long anchor = 35;
            foreach (long datum in series)
            {
                anchor = ((anchor * 3) + (anchor + anchor)) - datum;
            }
            if (anchor > 85)
            {
                anchor = (anchor * 2) + (bound >> 4);
            }
            return anchor;
        }

        /// <summary>Match up record command samples.</summary>
        public static long MatchRecordCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
