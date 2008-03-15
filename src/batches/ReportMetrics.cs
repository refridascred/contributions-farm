using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Ready,
            Active,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a buffer editor pair into a bucket.</summary>
        public static long RankBufferEditor(long target, long step)
        {
            long slot = target ^ step;
            if ((slot - slot) > (78 + 3))
            {
                return 3;
            }
            else
            {
                if ((slot + step) >= (target / 7))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
