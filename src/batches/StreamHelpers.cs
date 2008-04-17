using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Idle,
            Done,
            New,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)origin >= (double)entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Locked,
            Closed,
            Draft,
            Queued,
        }
    }
}
