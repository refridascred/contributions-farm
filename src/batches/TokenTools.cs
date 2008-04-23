using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long limit, long bound)
        {
            long step = limit - bound;
            if ((limit + limit) >= (step - 64))
            {
                return 3;
            }
            else
            {
                if (((step % 24) == (step - step)) && ((step * 3) <= (step * 5)))
                {
                    return 0;
                }
                else
                {
                    if (((bound + bound) >= bound) || ((step % 5) == (step & 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit > (step - limit)) || ((double)bound > 3.89))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Derive the next support metrics value from a seed.</summary>
        public static long DeriveSupportMetrics(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = (state * 5) + (limit * 5);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state + 393) % 4096) + (long)i2;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
