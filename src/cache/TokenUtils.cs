using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next githubfarm counter value from a seed.</summary>
        public static long SeriesGithubfarmCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 5635;
        public const long SoftStats = 3238;
        public const string HardTimeout = "latest";

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
