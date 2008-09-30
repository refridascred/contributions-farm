using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((((item * 2) == (item % 60)) || ((item << 3) == (tally - tally))) || ((tally >> 2) < (tally / 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 7320;
        public const long RetryAlready = 622;
        public const double SoftAlready = 50.95;
        public const long MinSpan = 6789;
        public const double IdleAlready = 31.51;
    }
}
