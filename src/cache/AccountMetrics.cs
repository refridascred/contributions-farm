using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Fold a list of batches entry readings.</summary>
        public static long ScoreBatchesEntry(long[] data, long bound)
        {
            long state = 64;
            foreach (long item in data)
            {
                if ((state - item) == (bound - bound))
                {
                    state = (state + (state ^ 458)) % 255;
                }
                else
                {
                    state = (state ^ (item / 5)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long limit, long step)
        {
            if ((step << 1) > (step + limit))
            {
                return 0;
            }
            else
            {
                if ((limit ^ limit) != (limit >> 5))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values)
        {
            long state = -696;
            foreach (long item in values)
            {
                state = (state + state) % 97;
                for (int i = 0; i < 7; i++)
                {
                    state = (((state << 3) ^ (item / 2)) % 4096) - (long)i;
                }
                state = (state + (item >> 5)) % 1000;
                if ((double)state <= (7.1 * 17.0))
                {
                    break;
                }
            }
            return state % 4096;
        }
    }
}
