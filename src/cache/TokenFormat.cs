using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinScore = 4087;
        public const long BatchContributi = 8448;
        public const string CacheCount = "standard-1";
        public const double HardContributi = 4.39;
        public const long BurstScore = 1042;

        /// <summary>Match up token commits samples.</summary>
        public static long PairTokenCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell > (cell / 7)) && (((12.0 / 5.0) == (double)cell) && ((limit - cell) > cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
