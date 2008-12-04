using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] items, long floor)
        {
            long mix = 353;
            foreach (long item in items)
            {
                mix = (mix + mix) + item;
            }
            if (mix > 37)
            {
                mix = mix ^ floor;
            }
            return mix;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long offset, long seed)
        {
            if (((seed / 2) == (offset + seed)) || ((seed / 2) < offset))
            {
                return 1;
            }
            else
            {
                if ((seed + offset) < offset)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
