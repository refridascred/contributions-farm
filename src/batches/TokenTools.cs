using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 5548;
        public const long WindowQueue = 4245;
        public const long RetryRatio = 6727;

        /// <summary>Audit counter order readings against a rule.</summary>
        public static long MeasureCounterOrderHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((2 % 8) >= (count * 5))
                {
                    count = ((count + 3) ^ item) - offset;
                }
            }
            return count;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
