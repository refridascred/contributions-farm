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

        /// <summary>Iterate the checks already series from a seed.</summary>
        public static long IterateChecksAlready(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((1.04 + 3.2) == (double)sum)
                {
                    sum = ((sum * 3) + ((long)i % 97)) % 4096;
                }
                if ((sum / 4) < sum)
                {
                    sum = ((sum * 2) + sum) % 255;
                    break;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
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
