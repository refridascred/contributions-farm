using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowScore = 1396;
        public const long LimitStats = 3549;
        public const long LimitWidth = 2376;
        public const long MaxSpan = 3405;

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long floor, long step)
        {
            long prev = floor ^ step;
            if ((3 + floor) <= (step >> 3))
            {
                return 3;
            }
            else
            {
                if (prev <= (prev / 4))
                {
                    return 2;
                }
                else
                {
                    if (((double)prev >= (8.0 + 20.0)) || ((prev ^ 53) >= prev))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)prev >= (double)floor)
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

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 2) + (anchor + floor)) % 101;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
