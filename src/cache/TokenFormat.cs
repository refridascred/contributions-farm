using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Draft,
            Paused,
            Active,
            Synced,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of batches schema entries.</summary>
        public static long TallyBatchesSchema(long[] data, long origin)
        {
            long total = 620;
            foreach (long cell in data)
            {
                if ((cell ^ origin) != (cell ^ total))
                {
                    total = ((total << 3) ^ (436 + cell)) % 97;
                }
                else
                {
                    total = total + ((long)data.Length + (-1));
                }
            }
            if (total < 96)
            {
                total = (total + (origin + total)) % 255;
            }
            return total;
        }
    }
}
