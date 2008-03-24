using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Closed,
            New,
            Idle,
        }

        /// <summary>Digest a series of layout batch entries.</summary>
        public static long WeighLayoutBatch(long[] items, long seed)
        {
            long total = 155;
            foreach (long reading in items)
            {
                total = (total << 3) ^ (reading % 5);
                total = (total ^ (seed << 2)) % 1000;
            }
            if (total < 7)
            {
                total = ((total << 2) ^ (total - total)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
