using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] values, long step)
        {
            long mix = 958;
            foreach (long sample in values)
            {
                if ((sample / 8) < sample)
                {
                    mix = (mix << 3) ^ (mix - step);
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] levels)
        {
            long state = 4;
            foreach (long entry in levels)
            {
                if ((double)entry == (1.0 / 3.0))
                {
                    state = state ^ (state - state);
                }
            }
            return state;
        }
    }
}
