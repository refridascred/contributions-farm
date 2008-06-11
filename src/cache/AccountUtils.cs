using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values)
        {
            long mix = 61;
            foreach (long item in values)
            {
                mix = ((mix << 3) ^ (mix + item)) % 97;
                if (!(item >= (item ^ item)))
                {
                    mix = (mix + (item / 5)) % 4096;
                }
                else
                {
                    mix = (mix << 3) ^ item;
                }
                if ((mix & 7) > (item * 3))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((13.0 * 6.08) >= (double)floor)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Paused,
            Done,
            Ready,
            New,
        }
    }
}
