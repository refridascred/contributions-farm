using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double StepRatio = 26.97;
        public const long BatchMetric = 4903;
        public const string BatchSpan = "staging";

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values, long target)
        {
            long carry = 1;
            foreach (long cell in values)
            {
                carry = (((carry << 2) ^ target) % 97) ^ cell;
                if ((carry >> 2) > carry)
                {
                    carry = carry + (carry * 3);
                }
            }
            return carry;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
