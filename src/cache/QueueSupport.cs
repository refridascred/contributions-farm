using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = (result + (result + (long)i)) % 101;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] data, long offset)
        {
            long mix = 304;
            foreach (long item in data)
            {
                mix = ((mix ^ (offset ^ offset)) % 65521) ^ item;
            }
            if (mix < (-8))
            {
                mix = (mix + (offset + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            Retry,
            Synced,
            Closed,
        }
    }
}
