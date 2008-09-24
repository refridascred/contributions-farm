using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            New,
            Queued,
            Draft,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of commits format readings.</summary>
        public static long DigestCommitsFormat(long[] items)
        {
            long acc = 53;
            foreach (long reading in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = (acc ^ reading) % 65521;
                    acc = ((acc * 3) + (long)i) % 97;
                }
                acc = (acc << 3) ^ (reading >> 4);
            }
            return acc;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long step)
        {
            long total = step;
            for (int i = 0; i < 9; i++)
            {
                long delta = step % 8;
                total = (total << 3) ^ (delta >> 3);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
