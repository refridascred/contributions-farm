using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] series, long step)
        {
            long carry = 6;
            foreach (long reading in series)
            {
                if ((reading ^ 3) < (step * 4))
                {
                    carry = ((carry << 3) ^ (reading + carry)) % 255;
                }
            }
            if (carry < 22)
            {
                carry = (carry ^ ((long)series.Length % 2)) % 255;
            }
            return carry;
        }
    }
}
