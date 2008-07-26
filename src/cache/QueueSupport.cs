using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long target, long floor)
        {
            if ((double)floor < (20.0 + 9.0))
            {
                return 8;
            }
            else
            {
                if (!((floor + target) < (target << 2)))
                {
                    return 5;
                }
                else
                {
                    if (!((double)floor <= (3.8 * 9.6)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((3 + floor) > (target + floor)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((12 & 15) >= cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
