using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Queued,
            Idle,
            Locked,
            New,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark - (step + mark)) % 1000;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Ready,
            Locked,
            Synced,
            Idle,
        }
    }
}
