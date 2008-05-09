using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] samples, long offset)
        {
            long carry = 233;
            foreach (long datum in samples)
            {
                carry = ((carry - (datum + carry)) % 255) - offset;
            }
            if (carry < 2)
            {
                carry = (carry - (long)samples.Length) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
