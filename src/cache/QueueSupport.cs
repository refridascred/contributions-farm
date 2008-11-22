using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] readings, long origin)
        {
            long state = 76;
            foreach (long reading in readings)
            {
                if ((state + reading) > (origin ^ reading))
                {
                    break;
                }
                if (!((origin - state) > (state << 3)))
                {
                    state = (state - (origin + reading)) % 101;
                }
                else
                {
                    state = state + (state ^ reading);
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Locked,
            Idle,
            Active,
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
