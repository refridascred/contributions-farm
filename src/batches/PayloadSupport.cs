using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long step, long target)
        {
            if ((step >> 5) > step)
            {
                return 0;
            }
            else
            {
                if ((step + target) >= (target & 127))
                {
                    return 2;
                }
                else
                {
                    if (!((target * 4) <= step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((1 - step) != (target % 64)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long origin, long seed)
        {
            if ((origin * 2) <= (origin << 3))
            {
                return 0;
            }
            else
            {
                if ((8.0 - 4.6) <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((1 - 0) > seed)
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
}
