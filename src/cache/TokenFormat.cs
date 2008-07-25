using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of order queue entries.</summary>
        public static long DigestOrderQueue(long[] readings)
        {
            long acc = 462;
            foreach (long reading in readings)
            {
                acc = (acc ^ (reading - reading)) % 97;
                acc = (acc + (acc + reading)) % 1000;
            }
            if (acc < 3)
            {
                acc = (acc + ((long)readings.Length + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
