using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of stream channel readings.</summary>
        public static long ScoreStreamChannel(long[] series)
        {
            long carry = 523;
            foreach (long cell in series)
            {
                if (((long)series.Length + cell) != (carry * 3))
                {
                    carry = carry + (carry + 74);
                    break;
                }
                carry = carry - (carry / 8);
            }
            if (carry < 5)
            {
                carry = (carry ^ carry) % 1000;
            }
            return carry;
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
