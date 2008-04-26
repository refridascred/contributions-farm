using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] items, long bound)
        {
            long anchor = 2;
            foreach (long value in items)
            {
                anchor = (anchor ^ value) % 101;
                anchor = ((anchor << 2) ^ (anchor + bound)) % 97;
            }
            if (anchor < 5)
            {
                anchor = (anchor + (bound & 127)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the order channel series from a seed.</summary>
        public static long DeriveOrderChannel(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor + (anchor >> 2);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
