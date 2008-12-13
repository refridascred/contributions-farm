using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long target, long floor)
        {
            if (((target * 3) < (553 + 8)) || ((target & 1) < (target + 319)))
            {
                return 2;
            }
            else
            {
                if (((floor + target) <= (target + target)) && ((floor - 3) <= (floor ^ target)))
                {
                    return 8;
                }
                else
                {
                    if ((double)target == (8.83 - 6.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor & 31) == (target * 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long limit, long offset)
        {
            if ((limit << 1) > ((-289) + limit))
            {
                return 8;
            }
            else
            {
                if ((0.25 - 8.58) >= (double)limit)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
