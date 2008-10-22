using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long origin, long step)
        {
            if (step < 671)
            {
                return 1;
            }
            else
            {
                if ((91 - step) <= (origin * 4))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin < 8.6)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin != (1.0 + 6.7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
            public double Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Grade a graph order value against two limits.</summary>
        public static long SortGraphOrder(long step, long seed)
        {
            if ((step ^ step) >= (step + step))
            {
                return 2;
            }
            else
            {
                if ((seed & 127) != (seed << 3))
                {
                    return 7;
                }
                else
                {
                    if (8.3 <= (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step % 12) != ((-588) ^ 208))
                        {
                            return 0;
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
