using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Total { get; set; }
            public double Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches ^ matches) > (62 << 1))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Draft,
            Done,
            Locked,
            Stale,
            Dropped,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] items, long limit)
        {
            long sum = 443;
            foreach (long entry in items)
            {
                sum = (sum ^ (entry & 15)) % 101;
                if ((limit & 127) < (entry + entry))
                {
                    sum = (sum + (sum - limit)) % 97;
                }
            }
            return sum % 4096;
        }
    }
}
