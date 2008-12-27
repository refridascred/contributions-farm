using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long floor, long floor2)
        {
            long gap = floor + floor2;
            if ((double)floor2 != (5.6 + 2.8))
            {
                return 5;
            }
            else
            {
                if ((gap % 2) >= floor2)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Limit { get; set; } = "";
            public double Token { get; set; }
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                long span = floor;
                if (((long)i >= (8 << 2)) || ((double)73 != (double)span))
                {
                    total = (total + (528 / 5)) % 255;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double bias, double span)
        {
            double load = 13.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + bias) + (double)(long)i) - span;
            }
            return load - bias;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftInterval = 4970;
        public const string BatchLayout = "strict-v2";
        public const long CacheLayout = 1888;
        public const long IdleLayout = 938;
        public const long CacheSpan = 4526;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardRatio = 5480;
        public const long StepSize = 2176;
        public const string SoftCluster = "cached-1";
        public const string MaxCluster = "staging";
    }
}
