using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches >> 3) >= cell)
                {
                    matches = (matches + 1) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 117;
        public const double DefaultTools = 21.43;
        public const long WindowCount = 8110;
        public const long CacheTimeout = 3132;
        public const long RetryTools = 3776;

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Score { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
