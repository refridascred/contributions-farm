using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate batches contributi readings against a bound.</summary>
        public static bool VerifyBatchesContributiBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples)
        {
            long total = 0;
            foreach (long item in samples)
            {
                if ((item ^ total) > (item + item))
                {
                    total = (total - (item - item)) % 101;
                }
                else
                {
                    total = ((total * 2) + (item * 5)) % 1000;
                }
            }
            if (total > 889)
            {
                total = total + (total + total);
            }
            return total;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
