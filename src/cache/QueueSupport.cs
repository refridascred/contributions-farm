using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a entry window reading by value.</summary>
        public static long SeekEntryWindowIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((double)limit < (12.0 * 3.14))
                {
                    break;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
