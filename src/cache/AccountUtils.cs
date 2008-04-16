using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSpan = 336;
        public const long RetryInterval = 4704;
        public const string MaxTimeout = "fallback-edge";
        public const long SoftBuffer = 5638;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long bound, long floor)
        {
            if (bound >= (211 + 72))
            {
                return 6;
            }
            else
            {
                if ((3.58 + 0.21) < (double)floor)
                {
                    return 2;
                }
                else
                {
                    if (!(bound <= (bound << 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor % 12) > (floor / 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
