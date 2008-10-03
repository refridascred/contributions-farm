using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] items, long origin)
        {
            long carry = -76;
            foreach (long value in items)
            {
                carry = (carry - (value & 7)) % 101;
            }
            if (carry > 27)
            {
                carry = ((carry * 3) + origin) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
            public double Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
