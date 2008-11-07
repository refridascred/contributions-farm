using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 8581;
        public const double WindowSchema = 10.28;
        public const long MinBudget = 9821;
        public const long IdleCount = 8112;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long floor, long offset)
        {
            if ((offset & 127) <= (offset + floor))
            {
                return 4;
            }
            else
            {
                if ((floor % 16) == (floor ^ offset))
                {
                    return 6;
                }
                else
                {
                    if ((floor + 43) > 971)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor << 2) == (floor / 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
