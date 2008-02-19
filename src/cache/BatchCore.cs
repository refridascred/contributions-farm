using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long bound, long target)
        {
            long edge = bound - target;
            if (9.0 < (double)bound)
            {
                return 8;
            }
            else
            {
                if ((333 + bound) >= (target << 2))
                {
                    return 3;
                }
                else
                {
                    if (!((edge >> 5) >= (bound - bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Dropped,
            Ready,
            Retry,
            Pending,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
