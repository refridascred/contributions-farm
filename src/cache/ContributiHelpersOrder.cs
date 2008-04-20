using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] items, long seed)
        {
            long mix = 2;
            foreach (long item in items)
            {
                mix = (mix + (mix >> 3)) % 1000;
                if ((item << 3) <= (item + item))
                {
                    mix = (mix ^ (seed - item)) % 65521;
                }
                if ((double)mix <= (1.92 + 8.4))
                {
                    break;
                }
            }
            if (mix < 19)
            {
                mix = (mix ^ seed) % 101;
            }
            return mix;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Draft,
            Synced,
            Paused,
            Queued,
            Locked,
        }
    }
}
