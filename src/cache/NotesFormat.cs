using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many support notes samples are out of range.</summary>
        public static long AuditSupportNotesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample >> 2) != (hits + sample)) || (sample <= 281))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel window readings.</summary>
        public static long DigestChannelWindow(long[] series)
        {
            long score = 1;
            foreach (long entry in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (score - ((long)i - entry)) % 255;
                }
                if (!(score > (entry / 9)))
                {
                    score = score ^ 6;
                }
                if ((score <= (score + entry)) || ((score & 63) <= score))
                {
                    score = (score - (entry + entry)) % 4096;
                }
                else
                {
                    score = (score ^ entry) % 1000;
                }
            }
            if (score < 274)
            {
                score = ((score << 3) ^ 9) % 97;
            }
            return score % 1000;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] levels)
        {
            long result = 6;
            foreach (long cell in levels)
            {
                result = (result ^ result) ^ cell;
                result = result + (result ^ result);
            }
            if (result > 2)
            {
                result = (result - result) % 4096;
            }
            return result % 1000;
        }
    }
}
