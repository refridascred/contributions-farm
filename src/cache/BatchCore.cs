using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit format stats readings against a rule.</summary>
        public static long MeasureFormatStatsMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (origin > item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Synced,
            Idle,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Locked,
            Done,
            Ready,
            Stale,
            Closed,
        }
    }
}
