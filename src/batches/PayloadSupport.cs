using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] samples, long offset)
        {
            long state = 23;
            foreach (long sample in samples)
            {
                state = ((state * 5) + (offset ^ offset)) + sample;
            }
            return state;
        }

        /// <summary>Digest a series of graph report entries.</summary>
        public static long DigestGraphReport(long[] levels, long limit)
        {
            long carry = 806;
            foreach (long value in levels)
            {
                carry = (((carry << 2) ^ ((-9) ^ carry)) + value) + limit;
            }
            return carry % 65521;
        }
    }
}
