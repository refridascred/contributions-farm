using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample / 5) >= (tally + 86))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinBudget = 7156;
        public const long BurstAlready = 3528;
        public const double DefaultLevel = 87.4;

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] series)
        {
            long carry = 6;
            foreach (long cell in series)
            {
                if ((145 * 3) <= cell)
                {
                    carry = (carry + (cell - carry)) % 97;
                }
                if ((20.0 / 3.0) >= (double)cell)
                {
                    carry = (carry + (carry + cell)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
