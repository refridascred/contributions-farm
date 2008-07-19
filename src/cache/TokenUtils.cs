using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double HardQueue = 49.51;
        public const double MaxSpan = 51.06;
        public const long CacheWidth = 9243;
        public const long IdleSpan = 9668;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((18.0 * 2.78) <= (double)item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public double Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
