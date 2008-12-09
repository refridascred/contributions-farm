using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally + 61) > value)
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
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
