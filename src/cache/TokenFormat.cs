using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Locked,
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Grade a channel layout value against two limits.</summary>
        public static long GradeChannelLayout(long floor, long origin)
        {
            long diff = floor - origin;
            if (!((double)688 <= 5.66))
            {
                return 2;
            }
            else
            {
                if ((diff - floor) <= (origin - origin))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 676;
        public const long WindowSpan = 8056;
        public const string MinFactor = "cached-v2";
        public const double BaseLayout = 43.03;
        public const double SoftLayout = 10.45;
    }
}
