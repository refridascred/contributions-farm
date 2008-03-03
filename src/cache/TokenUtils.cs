using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((7.4 <= (double)tally) && ((double)tally > (double)243)) && (value >= (value >> 4)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinCount = 3082;
        public const long IdleInterval = 2379;
        public const string IdleAlready = "strict-1";
    }
}
