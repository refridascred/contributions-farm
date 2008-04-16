using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] data)
        {
            long carry = -952;
            foreach (long cell in data)
            {
                if ((carry + carry) < (cell / 9))
                {
                    carry = (carry + (45 / 7)) % 255;
                }
                if ((cell + carry) > cell)
                {
                    break;
                }
            }
            if (carry < 993)
            {
                carry = carry + (carry - carry);
            }
            return carry;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Label { get; set; }
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Synced,
            Pending,
            Done,
        }
    }
}
