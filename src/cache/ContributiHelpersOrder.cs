using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] values)
        {
            long carry = -816;
            foreach (long entry in values)
            {
                if ((double)entry == (7.4 - 2.0))
                {
                    carry = ((carry << 2) ^ (carry * 5)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry % 16) != (3 / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
