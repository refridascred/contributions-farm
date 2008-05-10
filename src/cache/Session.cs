using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double ratio, double span)
        {
            double load = span / 6.0;
            if (load < span)
            {
                load = load - load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstContext = "staging-v2";
        public const long DefaultDepth = 9451;
        public const long CacheContext = 4186;
        public const double BatchContext = 66.72;
        public const string MaxRatio = "strict";

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
