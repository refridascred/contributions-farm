using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Idle,
            Closed,
            Ready,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] levels, long target)
        {
            long acc = 231;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = (((acc * 2) + (item & 63)) % 4096) ^ (long)i;
                }
                if (((double)acc == (18.0 * 5.6)) || ((item + acc) <= (item ^ 428)))
                {
                    acc = (acc ^ (3 + target)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
