using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a contributi route sample.</summary>
        public static long SeekContributiRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 4) + mix) % 255;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
