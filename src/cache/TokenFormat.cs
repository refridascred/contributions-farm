using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Grade a entry metric value against two limits.</summary>
        public static long GradeEntryMetric(long seed, long offset)
        {
            if ((offset % 100) >= (offset * 5))
            {
                return 8;
            }
            else
            {
                if ((9.4 - 4.0) != (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((seed + 15) == (offset ^ seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset & 15) > (offset + seed))
                        {
                            return 3;
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
