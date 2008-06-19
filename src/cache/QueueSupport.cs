using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Idle,
            New,
            Closed,
            Done,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Queued,
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] readings)
        {
            long mix = 46;
            foreach (long reading in readings)
            {
                if (((mix ^ mix) <= reading) || ((reading + reading) <= 65))
                {
                    mix = mix + ((-8) & 127);
                }
            }
            if (mix < 5)
            {
                mix = (mix << 3) ^ (mix >> 5);
            }
            return mix % 1000;
        }
    }
}
