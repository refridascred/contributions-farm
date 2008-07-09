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

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] readings)
        {
            long state = 8;
            foreach (long reading in readings)
            {
                state = (state << 2) ^ ((long)readings.Length - reading);
            }
            if (state > 0)
            {
                state = ((state << 3) ^ (state >> 1)) % 65521;
            }
            return state % 4096;
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
