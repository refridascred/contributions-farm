using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long origin, long seed)
        {
            long lane = origin + seed;
            if (lane > (seed + seed))
            {
                return 4;
            }
            else
            {
                if (603 <= (seed >> 5))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Region { get; set; }
            public double Rank { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double ratio, double floor)
        {
            double ratio2 = 3.62 / 9.0;
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 - (double)(long)i) - floor;
            }
            return ratio2 - ratio;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 8121;
        public const string WindowRatio = "stable-v2";
        public const string WindowLevel = "open-1";
    }
}
