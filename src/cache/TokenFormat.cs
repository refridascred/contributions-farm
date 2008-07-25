using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long seed, long limit)
        {
            if (!((limit - limit) <= (seed << 1)))
            {
                return 3;
            }
            else
            {
                if ((double)limit > (14.0 * 7.11))
                {
                    return 2;
                }
                else
                {
                    if (((limit % 60) != (limit << 1)) && ((3.0 / 5.0) == (double)limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((seed % 3) > (seed + limit)) && ((double)seed >= (7.56 + 5.3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Failed,
            Ready,
            New,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
