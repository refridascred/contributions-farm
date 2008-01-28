using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum == (6.0 + 4.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
