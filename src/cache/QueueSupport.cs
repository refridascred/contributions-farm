using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Failed,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Match up window farm samples.</summary>
        public static long OverlapWindowFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings, long limit)
        {
            long score = 8;
            foreach (long entry in readings)
            {
                if ((score / 3) <= (entry - limit))
                {
                    score = (score - (score >> 1)) % 97;
                }
            }
            return score;
        }
    }
}
