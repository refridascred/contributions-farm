using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long step)
        {
            long state = step;
            for (int i = 0; i < 14; i++)
            {
                state = state ^ (855 + state);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            New,
            Active,
            Stale,
            Ready,
        }
    }
}
