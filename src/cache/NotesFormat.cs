using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long target, long origin)
        {
            if (origin <= (52 >> 5))
            {
                return 5;
            }
            else
            {
                if (target <= (5 - target))
                {
                    return 2;
                }
                else
                {
                    if (4 <= target)
                    {
                        return 1;
                    }
                    else
                    {
                        if (target > origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Pending,
            Locked,
            Paused,
        }
    }
}
