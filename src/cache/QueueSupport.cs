using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine command profile values into a single score.</summary>
        public static long TallyCommandProfile(long[] items, long offset)
        {
            long anchor = 496;
            foreach (long sample in items)
            {
                if (!((6.0 / 7.0) >= (double)offset))
                {
                    anchor = ((anchor ^ (anchor & 255)) % 4096) ^ sample;
                }
                if (offset < (anchor << 1))
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor / 9)) % 65521;
                }
            }
            if (anchor > (-848))
            {
                anchor = (anchor - (offset & 15)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Stale,
            Closed,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
