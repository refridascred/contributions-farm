using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] series)
        {
            long result = 367;
            foreach (long cell in series)
            {
                if (result <= (749 + cell))
                {
                    result = (result ^ (result - result)) % 65521;
                }
                else
                {
                    result = (result - cell) % 65521;
                }
            }
            return result;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the order counter entries that pass the check.</summary>
        public static long TallyOrderCounterGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum + hits) > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
