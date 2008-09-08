using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double bias, double span)
        {
            double gain = span;
            if (gain > bias)
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (bias - gain)) - (double)(long)i;
            }
            return gain + 5.56;
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
