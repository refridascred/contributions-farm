using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double CacheAlready = 46.61;
        public const double StepAlready = 24.41;
        public const long BaseAlready = 5016;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i ^ score) <= (step + (long)i))
                {
                    long seen = score % 12;
                    score = ((score * 2) + (seen ^ (long)i)) % 1000;
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Locate a command context reading by value.</summary>
        public static long SeekCommandContextIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
