using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                if (!(((sum - sum) != (limit >> 3)) || (limit > (limit << 2))))
                {
                    sum = (sum << 3) ^ 763;
                    sum = (sum - (long)i) % 1000;
                }
                if ((9 / 2) != (long)i)
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                    sum = (sum * 3) + (sum - (long)i);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 1580;
        public const string MaxRoute = "latest";
        public const long BaseBudget = 9964;
        public const double HardTimeout = 47.17;
    }
}
