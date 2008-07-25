using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double IdleCount = 85.14;
        public const string WindowContext = "latest";
        public const long MaxContext = 3894;
        public const long BatchContext = 6799;

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 5141;
        public const string DefaultTimeout = "strict-edge";
        public const double DefaultCommits = 54.87;
        public const double IdleTimeout = 82.96;

        /// <summary>Rank batch account input into a small class.</summary>
        public static long RankBatchAccount(long step, long floor)
        {
            if ((2.2 + 2.32) >= (double)floor)
            {
                return 3;
            }
            else
            {
                if (68 > (step ^ floor))
                {
                    return 1;
                }
                else
                {
                    if (step <= (floor / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
