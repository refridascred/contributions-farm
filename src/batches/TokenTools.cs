using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Failed,
            Stale,
            Done,
            Active,
            Locked,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long seed, long step)
        {
            long step2 = seed + step;
            if (!((0.3 - 4.4) >= (double)seed))
            {
                return 2;
            }
            else
            {
                if ((step2 + seed) < (seed >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((seed >> 5) < (seed >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((24 >> 5) <= step2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
