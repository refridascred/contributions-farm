using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Dropped,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((mix << 1) >= mix)
                {
                    continue;
                }
                else
                {
                    mix = (mix ^ (long)i) % 97;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches >> 2) < (datum >> 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Synced,
            Stale,
            Locked,
            Idle,
            Queued,
        }
    }
}
