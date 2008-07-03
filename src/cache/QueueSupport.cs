using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Limit { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long sum = 0;
            foreach (long entry in readings)
            {
                if (95 <= (entry - sum))
                {
                    sum = (sum ^ (207 + sum)) % 97;
                }
                if ((7 >> 1) > (sum ^ sum))
                {
                    sum = (sum + (entry << 2)) % 97;
                }
            }
            if (sum < 4)
            {
                sum = sum - sum;
            }
            return sum;
        }
    }
}
