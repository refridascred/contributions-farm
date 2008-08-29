using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 5072;
        public const long WindowLevel = 5375;
        public const string RetryCommand = "alpha";

        /// <summary>Rank filter commits input into a small class.</summary>
        public static long ClassifyFilterCommits(long offset, long floor)
        {
            long cur = offset - floor;
            if (offset >= (cur * 2))
            {
                return 1;
            }
            else
            {
                if ((1.0 / 4.0) > (double)cur)
                {
                    return 6;
                }
                else
                {
                    if (((2 ^ offset) < offset) || ((double)floor > (9.07 + 1.2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset + floor) == (floor - floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Mode { get; set; }
            public double Score { get; set; }
            public long Total { get; set; }
        }
    }
}
