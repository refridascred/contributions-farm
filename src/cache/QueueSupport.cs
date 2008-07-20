using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = (total + total) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 17;
        public const long BatchOrder = 20;
        public const long DefaultDepth = 7649;

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 9557;
        public const long WindowBatches = 2445;
        public const long BatchScore = 4939;
    }
}
