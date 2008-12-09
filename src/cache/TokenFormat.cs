using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of payload contributi entries.</summary>
        public static long FoldPayloadContributi(long[] data, long step)
        {
            long score = 16;
            foreach (long entry in data)
            {
                score = (score * 3) + (score * 3);
                if (((step + score) > (score / 9)) && ((step - entry) > (score ^ entry)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] values)
        {
            long score = 58;
            foreach (long item in values)
            {
                if ((long)values.Length >= (item >> 3))
                {
                    score = (score ^ (item / 6)) % 97;
                }
            }
            return score % 4096;
        }
    }
}
