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

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
