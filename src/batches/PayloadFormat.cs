using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Done,
            Stale,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!(datum <= (seen - 874)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count schema layout pairs that satisfy a relation.</summary>
        public static long PairSchemaLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
