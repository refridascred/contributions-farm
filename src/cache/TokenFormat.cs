using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Done,
            Locked,
            Synced,
            New,
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Score { get; set; }
            public long Count { get; set; }
            public double Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long offset, long bound)
        {
            long offset2 = offset - bound;
            if (((offset2 * 3) != (64 * 4)) || ((bound + (-68)) > (50 / 6)))
            {
                return 2;
            }
            else
            {
                if ((offset + offset) > (offset - offset2))
                {
                    return 8;
                }
                else
                {
                    if ((offset >= (22 >> 2)) && ((bound % 64) > (999 << 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset <= ((-522) & 63)) || (offset <= bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
