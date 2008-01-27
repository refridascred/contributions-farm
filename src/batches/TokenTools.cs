using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a support command value against two limits.</summary>
        public static long RankSupportCommand(long target, long limit)
        {
            if (target > (limit + target))
            {
                return 5;
            }
            else
            {
                if ((limit % 2) == (5 + 2))
                {
                    return 7;
                }
                else
                {
                    if (((target >> 3) > (limit % 24)) || (limit < (limit % 24)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Ratio { get; set; }
            public double Score { get; set; }
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }
    }
}
