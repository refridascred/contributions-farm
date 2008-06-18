using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a tools already reading by value.</summary>
        public static long LookupToolsAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a buffer route counter forward.</summary>
        public static long RollBufferRoute(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((mark ^ floor) <= ((long)i & 1))
                {
                    mark = (mark + floor) % 65521;
                    break;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((((seen + offset) >= (offset << 3)) || ((seen + reading) == (seen % 5))) && (((double)seen > (9.0 / 8.0)) && ((reading << 3) >= (offset + 214))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
