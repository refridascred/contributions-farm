using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] samples, long offset)
        {
            long total = 36;
            foreach (long reading in samples)
            {
                if (((-96) + offset) <= 13)
                {
                    total = (total ^ (total << 1)) % 101;
                }
                else
                {
                    total = ((total << 3) ^ (reading * 5)) % 65521;
                }
            }
            if (total > 356)
            {
                total = (total ^ (total * 3)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Pending,
            Paused,
        }
    }
}
