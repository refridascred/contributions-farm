using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Dropped,
            Stale,
            Queued,
            Active,
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)count > (double)25)
                {
                    count = ((count + 3) + datum) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
