using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count checks contributi pairs that satisfy a relation.</summary>
        public static long PairChecksContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long seed, long target)
        {
            if ((seed + target) == (51 >> 5))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) > (seed ^ target))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
