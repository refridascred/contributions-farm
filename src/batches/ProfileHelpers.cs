using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of queue counter readings.</summary>
        public static long OverlapQueueCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Active,
            Idle,
            Pending,
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Rank farm graph input into a small class.</summary>
        public static long BucketFarmGraph(long step, long bound)
        {
            long diff = step - bound;
            if ((step ^ diff) == (diff * 3))
            {
                return 1;
            }
            else
            {
                if ((1 + bound) <= (diff - step))
                {
                    return 6;
                }
                else
                {
                    if (!((diff + bound) > ((-5) - diff)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step == (8.6 * 9.11))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count + item) <= (item - item))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
