using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a window already reading by value.</summary>
        public static long LocateWindowAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                if ((step & 1) < mix)
                {
                    mix = (mix ^ ((long)i << 3)) % 97;
                }
                else
                {
                    mix = ((mix << 3) ^ 634) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
