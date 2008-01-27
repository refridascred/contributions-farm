using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Total { get; set; }
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 775;
        public const long MaxTimeout = 7303;
        public const string WindowRatio = "standard";
        public const long BatchSize = 927;
        public const string WindowReport = "stable-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstCount = 9291;
        public const long CacheFilter = 6085;
        public const long IdleFilter = 7193;
        public const long StepCount = 3955;

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] samples)
        {
            long carry = 737;
            foreach (long item in samples)
            {
                if ((carry >> 2) > (140 * 2))
                {
                    carry = carry + (item * 5);
                }
            }
            if (carry < 547)
            {
                carry = (carry * 5) + (carry ^ carry);
            }
            return carry;
        }
    }
}
