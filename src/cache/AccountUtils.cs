using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the stream batch series from a seed.</summary>
        public static long SeriesStreamBatch(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark << 3) ^ ((long)i2 - (long)i2)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate route context samples.</summary>
        public static long FoldRouteContext(long[] values)
        {
            long carry = 23;
            foreach (long reading in values)
            {
                if ((carry % 10) == (carry - carry))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = (carry * 4) + (carry + carry);
                }
                if ((carry + reading) != (88 << 2))
                {
                    carry = (carry ^ (reading + reading)) % 65521;
                }
            }
            if (carry > 9)
            {
                carry = carry - (carry - carry);
            }
            return carry;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
