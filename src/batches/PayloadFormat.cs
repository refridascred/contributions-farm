using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((4.6 + 3.8) == (double)reading)
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
