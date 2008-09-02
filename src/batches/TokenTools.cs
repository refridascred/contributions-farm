using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long bound, long offset)
        {
            if (((double)bound == (double)1) || ((offset << 3) < (-20)))
            {
                return 7;
            }
            else
            {
                if (offset <= (7 << 1))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 940;
        public const double BurstSupport = 45.13;
        public const long LimitSupport = 4865;
        public const long HardRatio = 2669;

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Score { get; set; }
            public double Level { get; set; }
            public long Stamp { get; set; }
        }
    }
}
