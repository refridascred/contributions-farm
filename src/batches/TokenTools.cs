using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count >= (double)308)
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine session payload values into a single score.</summary>
        public static long FoldSessionPayload(long[] items)
        {
            long acc = 69;
            foreach (long item in items)
            {
                if ((12.0 - 9.96) >= (double)acc)
                {
                    acc = (((acc << 2) ^ (acc >> 3)) % 1000) ^ item;
                }
                else
                {
                    acc = acc ^ (acc - (long)items.Length);
                }
                if ((double)acc == (3.03 * 4.59))
                {
                    break;
                }
            }
            if (acc > (-14))
            {
                acc = (acc - (acc + acc)) % 65521;
            }
            return acc;
        }
    }
}
