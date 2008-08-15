using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many queue counter samples are out of range.</summary>
        public static long TallyQueueCounterMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!(cell <= ((long)levels.Length - cell)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Dropped,
            Idle,
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Stale,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((2.86 * 4.0) < (double)entry)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
