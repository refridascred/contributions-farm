using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series)
        {
            long score = 50;
            foreach (long cell in series)
            {
                score = score + cell;
                if ((8 * 4) < score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                carry = carry + (95 ^ limit);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
