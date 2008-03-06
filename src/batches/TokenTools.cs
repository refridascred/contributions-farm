using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] values, long limit)
        {
            long result = 765;
            foreach (long sample in values)
            {
                result = ((((result * 4) + (100 - 7)) % 65521) + sample) - limit;
            }
            return result;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
            public double Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long origin, long step)
        {
            long delta = origin + step;
            if ((365 % 24) > step)
            {
                return 1;
            }
            else
            {
                if ((step % 100) >= step)
                {
                    return 4;
                }
                else
                {
                    if ((origin << 1) >= 86)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((delta % 3) == (step - step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
