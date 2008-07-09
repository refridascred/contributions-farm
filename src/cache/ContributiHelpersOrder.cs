using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate order graph samples.</summary>
        public static long TallyOrderGraph(long[] data)
        {
            long mix = 632;
            foreach (long entry in data)
            {
                mix = ((mix + (mix - mix)) % 65521) - entry;
            }
            return mix;
        }

        /// <summary>Roll a session layout counter forward.</summary>
        public static long IterateSessionLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor + (anchor + bound)) % 97;
                anchor = (anchor + (bound & 31)) % 255;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Synced,
            Stale,
            New,
            Dropped,
        }
    }
}
