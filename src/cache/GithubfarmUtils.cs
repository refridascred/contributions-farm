using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every entry counter entry stays within the limit.</summary>
        public static bool CheckEntryCounterRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                long lane = result;
                if ((lane ^ result) < (result << 2))
                {
                    lane = (lane << 2) ^ (217 ^ offset);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleScore = "primary-1";
        public const long SoftStats = 946;
        public const long StepInterval = 8019;
        public const double SoftSize = 39.77;
        public const long BaseStats = 401;

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
