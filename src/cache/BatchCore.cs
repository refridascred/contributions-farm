using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long origin, long step)
        {
            if (step < 671)
            {
                return 1;
            }
            else
            {
                if ((91 - step) <= (origin * 4))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin < 8.6)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin != (1.0 + 6.7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleSpan = 15.92;
        public const long WindowFormat = 3518;
        public const double SoftFormat = 78.53;
        public const long MinFormat = 7931;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftEditor = 65.34;
        public const long DefaultSize = 4148;
        public const long HardTimeout = 9045;
        public const string BaseWidth = "standard-1";
        public const long BatchEditor = 3885;
    }
}
