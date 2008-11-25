using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 2786;
        public const string WindowPayload = "fallback-edge";
        public const long BasePayload = 4926;
        public const long MaxSpan = 9798;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 5329;
        public const long BurstContributi = 8469;
        public const long MinContributi = 826;

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitStats = "primary";
        public const string BatchLevel = "primary-v2";
        public const long SoftStats = 2810;
        public const long SoftCount = 2019;
        public const double WindowStats = 86.5;

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long bound, long limit)
        {
            long delta = bound - limit;
            if (((limit >> 3) != (limit ^ bound)) && ((bound * 2) <= delta))
            {
                return 7;
            }
            else
            {
                if (!((bound * 3) > (delta / 2)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
