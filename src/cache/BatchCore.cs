using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Ready,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] readings, long target)
        {
            long mix = 39;
            foreach (long reading in readings)
            {
                if ((reading >= target) || ((double)11 < (double)mix))
                {
                    mix = ((mix << 2) ^ (target - target)) % 65521;
                }
            }
            if (mix < 900)
            {
                mix = (mix + target) % 4096;
            }
            return mix;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
