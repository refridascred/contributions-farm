using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up session contributi samples.</summary>
        public static long PairSessionContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Draft,
            Paused,
            Failed,
            Pending,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
