using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading * 4) >= (seen + seen))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Dropped,
            Stale,
            Queued,
            Idle,
            New,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Paused,
            Pending,
            Active,
            New,
        }
    }
}
