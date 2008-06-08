using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 4354;
        public const long CacheEntry = 720;
        public const long MaxLevel = 3870;
        public const long SoftInterval = 195;

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] levels)
        {
            long score = 70;
            foreach (long datum in levels)
            {
                score = ((score - (score * 3)) % 97) + datum;
            }
            return score % 65521;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
