using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            New,
            Closed,
            Synced,
            Active,
            Ready,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] series, long bound)
        {
            long carry = 687;
            foreach (long value in series)
            {
                carry = ((carry * 3) + bound) % 97;
                if (((long)series.Length ^ bound) <= (value & 1))
                {
                    carry = ((carry << 3) ^ (59 << 3)) % 101;
                }
                else
                {
                    carry = (carry - (carry * 5)) % 255;
                }
            }
            if (carry > 0)
            {
                carry = (carry * 3) + (carry + carry);
            }
            return carry;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Token { get; set; }
            public double Offset { get; set; }
            public bool Owner { get; set; }
            public bool Label { get; set; }
        }
    }
}
