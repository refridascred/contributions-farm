using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry > (double)579)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] samples, long step)
        {
            long score = -211;
            foreach (long item in samples)
            {
                if (item > (score + item))
                {
                    score = (score - (68 / 7)) % 4096;
                }
            }
            if (score < 266)
            {
                score = score - step;
            }
            return score % 97;
        }
    }
}
