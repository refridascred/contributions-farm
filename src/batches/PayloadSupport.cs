using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                long gap = (state % 64) + ((long)i ^ state);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state - gap) % 101) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
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
