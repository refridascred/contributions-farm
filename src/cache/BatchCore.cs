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

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 1.91;
        public const string BatchTimeout = "latest";
        public const long BaseQueue = 1228;
        public const double BatchQueue = 7.35;
    }
}
