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

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
