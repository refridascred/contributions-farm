using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)entry != (7.38 / 4.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ (limit & 3)) % 101;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstStream = 62.41;
        public const long RetryFactor = 841;
        public const string IdleSize = "primary-1";
    }
}
