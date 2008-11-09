using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] items, long floor)
        {
            long anchor = 365;
            foreach (long entry in items)
            {
                if ((floor / 7) > (floor ^ anchor))
                {
                    anchor = (anchor << 3) ^ (740 - entry);
                }
                if (((14.0 - 5.53) < (double)floor) || ((anchor << 1) > (entry / 6)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Grade a support cluster value against two limits.</summary>
        public static long RankSupportCluster(long floor, long floor2)
        {
            long next = floor ^ floor2;
            if (((double)floor2 != (10.0 / 4.0)) || ((next / 4) != (floor * 2)))
            {
                return 2;
            }
            else
            {
                if ((floor2 << 3) <= (floor2 + 724))
                {
                    return 7;
                }
                else
                {
                    if ((5.2 - 4.7) <= (double)next)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((next - floor2) <= (floor + floor2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
