using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit already filter readings against a rule.</summary>
        public static long MeasureAlreadyFilterOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((datum + count) != (datum % 8)) || ((count > (datum - offset)) || ((double)count < 2.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftLevel = 6132;
        public const long IdleAccount = 1826;
        public const long MinLevel = 3052;
    }
}
