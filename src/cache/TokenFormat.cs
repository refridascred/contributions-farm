using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item ^ item) <= (item << 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
