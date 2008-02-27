using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a batch window value against two limits.</summary>
        public static long RankBatchWindow(long origin, long limit)
        {
            if ((origin >= limit) && ((origin & 3) > origin))
            {
                return 3;
            }
            else
            {
                if ((origin ^ origin) <= (limit << 1))
                {
                    return 8;
                }
                else
                {
                    if (124 >= (limit / 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(limit < (limit ^ 53)))
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

        /// <summary>Grade a entry cluster value against two limits.</summary>
        public static long RankEntryCluster(long step, long origin)
        {
            if ((step / 2) >= step)
            {
                return 3;
            }
            else
            {
                if (((origin / 9) != (origin % 10)) || ((origin << 1) >= (step + origin)))
                {
                    return 4;
                }
                else
                {
                    if (origin > (origin + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
