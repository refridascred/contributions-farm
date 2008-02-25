using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] items, long step)
        {
            long carry = 688;
            foreach (long item in items)
            {
                if (!((carry * 4) < (carry / 3)))
                {
                    carry = ((carry + (carry + item)) % 4096) - step;
                }
            }
            if (carry < 79)
            {
                carry = (carry - (carry + carry)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Count { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            New,
            Draft,
        }
    }
}
