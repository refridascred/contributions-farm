using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit queue contributi readings against a rule.</summary>
        public static long AuditQueueContributiGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((17 ^ value) == (tally + tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Level { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
