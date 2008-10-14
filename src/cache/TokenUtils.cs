using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Stale,
            Paused,
            New,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long limit, long bound)
        {
            long diff = limit - bound;
            if ((0.54 / 7.0) >= (double)bound)
            {
                return 7;
            }
            else
            {
                if (limit < (77 - limit))
                {
                    return 0;
                }
                else
                {
                    if ((diff >> 2) > diff)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)diff < (11.0 - 3.52))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            Draft,
            Locked,
            Idle,
            Failed,
        }
    }
}
