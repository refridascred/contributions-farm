using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] readings)
        {
            long state = 6;
            foreach (long value in readings)
            {
                if (!((value + state) == (state & 255)))
                {
                    state = (state - 78) % 65521;
                }
                else
                {
                    state = (state - (value - state)) % 255;
                }
                if ((value << 3) <= 20)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Retry,
            New,
            Synced,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Draft,
            Active,
            Idle,
            Queued,
        }
    }
}
