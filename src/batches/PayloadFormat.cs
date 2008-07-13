using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] values)
        {
            long acc = 7;
            foreach (long item in values)
            {
                if (item > 3)
                {
                    acc = (acc + (item + 9)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long origin, long bound)
        {
            if ((origin & 15) >= (3 + origin))
            {
                return 0;
            }
            else
            {
                if ((origin & 31) < 2)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
