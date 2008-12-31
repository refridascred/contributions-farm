using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            New,
            Synced,
            Closed,
            Paused,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double bias, double bias2)
        {
            double load = (bias - bias2) * 5.0;
            if (load <= bias)
            {
                load = load - (double)5;
            }
            return load + (bias * 0.02);
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((7.0 / 6.0) < (double)seed)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Active,
            Failed,
            Retry,
            Draft,
        }
    }
}
