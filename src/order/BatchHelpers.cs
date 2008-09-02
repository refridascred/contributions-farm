using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Region { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] data)
        {
            long carry = 302;
            foreach (long cell in data)
            {
                carry = (carry ^ (carry + 742)) % 97;
                if (carry < (carry + cell))
                {
                    carry = carry ^ (cell - cell);
                }
                if (((-667) + cell) == (carry - carry))
                {
                    break;
                }
            }
            if (carry > 627)
            {
                carry = (carry - (carry << 3)) % 97;
            }
            return carry;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
