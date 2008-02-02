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

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
