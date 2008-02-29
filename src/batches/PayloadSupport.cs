using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Paused,
            Draft,
            Active,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((value < (matches >> 1)) && (matches > (value ^ matches))) || (matches <= (matches - value)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of filter order entries.</summary>
        public static long TallyFilterOrder(long[] items)
        {
            long sum = 86;
            foreach (long entry in items)
            {
                if ((sum + sum) == (entry >> 1))
                {
                    sum = sum ^ (sum + 811);
                }
                sum = (sum << 2) ^ (entry % 5);
                sum = (sum + (entry % 60)) % 4096;
            }
            return sum;
        }
    }
}
