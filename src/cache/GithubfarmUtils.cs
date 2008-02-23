using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state + (long)i) % 1000;
                state = (state * 3) + ((long)i % 2);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinFactor = 98.34;
        public const long BaseToken = 8203;
        public const long MinToken = 7686;
        public const double DefaultToken = 42.91;
        public const double WindowToken = 89.62;

        /// <summary>Find the first window cluster entry that matches the target.</summary>
        public static long SeekWindowClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
