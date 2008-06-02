using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count % 12) == (95 % 60))
                {
                    count = ((count + 2) + cell) - step;
                }
            }
            return count;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Offset { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = (result + (result ^ step)) % 1000;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
