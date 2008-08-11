using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long offset, long seed)
        {
            if (seed < offset)
            {
                return 2;
            }
            else
            {
                if ((seed + 51) <= (offset + (-68)))
                {
                    return 3;
                }
                else
                {
                    if ((17.0 / 5.0) >= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset < (seed - offset))
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

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseTimeout = 7110;
        public const long HardWidth = 1719;
        public const long SoftChannel = 2574;
        public const string SoftDepth = "primary-edge";
        public const long HardLevel = 1546;
    }
}
