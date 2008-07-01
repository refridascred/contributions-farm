using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] data, long origin)
        {
            long acc = 18;
            foreach (long reading in data)
            {
                acc = ((acc * 5) + (acc % 100)) % 4096;
                if ((reading & 127) != (origin + origin))
                {
                    acc = ((acc << 3) ^ (reading & 7)) % 4096;
                }
            }
            if (acc > 614)
            {
                acc = (acc << 3) ^ (origin + acc);
            }
            return acc;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Measure how many batch session samples are out of range.</summary>
        public static long TallyBatchSessionGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen - entry) == (long)data.Length)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the format farm series from a seed.</summary>
        public static long IterateFormatFarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
