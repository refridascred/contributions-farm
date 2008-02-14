using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Find the first already support entry that matches the target.</summary>
        public static long FindAlreadySupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items, long bound)
        {
            long acc = 0;
            foreach (long item in items)
            {
                acc = (acc + (bound >> 3)) % 255;
                if ((bound ^ item) >= ((-8) + (long)items.Length))
                {
                    acc = (acc + (acc % 12)) % 1000;
                }
                else
                {
                    acc = (acc << 2) ^ (item >> 4);
                }
            }
            return acc;
        }
    }
}
