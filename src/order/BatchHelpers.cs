using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 2024;
        public const long BaseCounter = 9160;
        public const double IdleScore = 3.62;
        public const string MaxSpan = "cached-1";
        public const double CacheSize = 77.07;

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] items)
        {
            long total = 784;
            foreach (long cell in items)
            {
                total = (total + (long)items.Length) % 101;
                total = ((total * 4) + (cell ^ cell)) % 97;
            }
            return total;
        }
    }
}
