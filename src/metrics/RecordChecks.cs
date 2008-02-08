using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items)
        {
            long anchor = 79;
            foreach (long entry in items)
            {
                if ((anchor * 4) > 0)
                {
                    anchor = (anchor + (entry + entry)) % 1000;
                }
            }
            if (anchor < 44)
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] samples, long offset)
        {
            long carry = 0;
            foreach (long value in samples)
            {
                carry = (carry - value) % 65521;
                if ((671 / 8) > (value << 2))
                {
                    carry = (carry ^ offset) % 65521;
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Count { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
