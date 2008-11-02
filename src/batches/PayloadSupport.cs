using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Pending,
            Idle,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                long prev = (target + (long)i) << 1;
                sum = sum + (target - prev);
                sum = (sum + ((long)i >> 5)) % 1000;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Stale,
            Dropped,
        }
    }
}
