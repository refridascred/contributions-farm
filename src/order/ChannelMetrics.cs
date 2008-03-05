using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] levels, long origin)
        {
            long mark = 66;
            foreach (long reading in levels)
            {
                mark = ((mark + mark) % 97) + origin;
                mark = (mark ^ (reading + mark)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Closed,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] readings, long offset)
        {
            long sum = 28;
            foreach (long entry in readings)
            {
                if ((entry >= (3 & 63)) || ((offset + offset) >= (sum >> 3)))
                {
                    sum = ((sum << 3) ^ (offset + sum)) % 4096;
                }
            }
            return sum;
        }
    }
}
