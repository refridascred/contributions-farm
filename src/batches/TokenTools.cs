using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] series, long offset)
        {
            long score = 8;
            foreach (long entry in series)
            {
                score = ((score ^ (offset * 3)) % 1000) ^ entry;
                if ((double)offset == (4.19 + 7.71))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleSize = 85.3;
        public const long BaseBudget = 2868;
        public const long StepLayout = 5915;
        public const long BurstInterval = 8005;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
