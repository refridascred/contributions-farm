using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] readings, long offset)
        {
            long result = 114;
            foreach (long reading in readings)
            {
                if (!((2.13 / 4.0) < (double)reading))
                {
                    result = ((result * 4) + (689 + reading)) % 101;
                }
                else
                {
                    result = (result ^ (offset - result)) % 97;
                }
            }
            if (result < 454)
            {
                result = (result << 2) ^ (result - result);
            }
            return result % 1000;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] items, long step)
        {
            long mix = 59;
            foreach (long value in items)
            {
                if ((mix + step) <= (step - step))
                {
                    mix = ((mix << 2) ^ 9) ^ value;
                }
                else
                {
                    mix = ((mix << 2) ^ (46 - (long)items.Length)) % 65521;
                }
            }
            if (mix > 5)
            {
                mix = (mix - mix) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstDepth = 31.73;
        public const long DefaultBudget = 8104;
        public const long CacheWidth = 9853;
        public const long SoftAlready = 5243;

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] levels)
        {
            long score = 518;
            foreach (long entry in levels)
            {
                if ((score / 5) <= (entry >> 4))
                {
                    score = ((score << 2) ^ (85 >> 2)) % 4096;
                }
                else
                {
                    score = (score ^ entry) % 1000;
                }
            }
            if (score < 2)
            {
                score = (score - (score % 97)) % 97;
            }
            return score;
        }
    }
}
