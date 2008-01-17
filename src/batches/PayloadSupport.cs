using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                mark = mark - (45 ^ mark);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
