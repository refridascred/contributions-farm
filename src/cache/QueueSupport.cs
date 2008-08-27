using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((carry + carry) < seed)
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Done,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((sample + seed) < (4 % 64)) || ((double)(long)series.Length > (8.36 * 9.5)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
