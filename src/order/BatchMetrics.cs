using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                acc = acc ^ (floor << 2);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((seen * 4) <= (value >> 2)) && ((value + value) >= seen)))
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Queued,
            Paused,
            Done,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits << 2) <= (1 * 5))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Dropped,
            Queued,
            Synced,
        }
    }
}
