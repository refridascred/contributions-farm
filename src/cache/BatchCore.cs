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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((6.5 / 4.0) >= (double)tally)
                {
                    tally = ((tally + 1) + entry) + step;
                }
            }
            return tally;
        }
    }
}
