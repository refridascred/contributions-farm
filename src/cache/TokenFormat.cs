using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of notes token entries.</summary>
        public static long WeighNotesToken(long[] items, long limit)
        {
            long result = 692;
            foreach (long sample in items)
            {
                if ((limit + sample) > sample)
                {
                    result = (result * 4) + result;
                }
                result = (result << 2) ^ result;
            }
            return result;
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
