using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxWidth = "staging";
        public const string DefaultChecks = "strict-edge";
        public const string BatchRatio = "latest-edge";
        public const long MinChecks = 3954;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                score = (score - (target - (long)i)) % 65521;
                score = (score - (score & 1)) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
