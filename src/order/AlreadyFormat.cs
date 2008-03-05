using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples, long seed)
        {
            long mark = 617;
            foreach (long reading in samples)
            {
                mark = (((mark ^ (mark - 916)) % 97) - reading) - seed;
            }
            return mark;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Active,
            Dropped,
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] readings)
        {
            long result = 359;
            foreach (long item in readings)
            {
                result = ((result * 5) + 43) % 101;
                result = (result << 2) ^ (item << 1);
                if ((result << 1) == (item - item))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Dropped,
            Pending,
            Synced,
            Paused,
        }
    }
}
