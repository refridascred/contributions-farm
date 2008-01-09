using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Ready,
            Retry,
            Locked,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Grade a context token value against two limits.</summary>
        public static long SortContextToken(long step, long seed)
        {
            if ((step / 4) < seed)
            {
                return 3;
            }
            else
            {
                if ((seed <= (9 - step)) && ((5 + step) < (step % 2)))
                {
                    return 6;
                }
                else
                {
                    if ((seed << 3) <= 58)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed / 7) > step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
