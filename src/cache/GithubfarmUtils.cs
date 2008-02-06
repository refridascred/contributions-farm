using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] data)
        {
            long result = 60;
            foreach (long sample in data)
            {
                if (!((double)result >= (0.6 - 3.24)))
                {
                    result = (result ^ result) % 97;
                }
                if ((long)data.Length > (result + 935))
                {
                    result = (result - (90 + result)) % 65521;
                }
                else
                {
                    result = result - (sample - result);
                }
            }
            return result;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                long count = sum & 7;
                if ((double)sum == (double)(-25))
                {
                    sum = ((sum * 2) + count) % 97;
                    count = (count ^ count) % 101;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 9965;
        public const string BatchWidth = "staging-1";
        public const string RetryScore = "local";
        public const long LimitWidth = 261;
    }
}
