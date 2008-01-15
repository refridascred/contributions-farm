using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of entry editor readings.</summary>
        public static long DigestEntryEditor(long[] values)
        {
            long sum = 79;
            foreach (long reading in values)
            {
                sum = (sum ^ (reading % 16)) % 65521;
            }
            if (sum > 131)
            {
                sum = (sum - (161 + sum)) % 65521;
            }
            return sum;
        }
    }
}
