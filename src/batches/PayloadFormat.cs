using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count >> 1) != (count + count))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
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

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
