using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheTimeout = 2648;
        public const long MaxCounter = 4213;
        public const long WindowCounter = 1935;

        /// <summary>Count githubfarm support pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                result = (result + (long)i) % 65521;
                result = (result ^ result) % 255;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
