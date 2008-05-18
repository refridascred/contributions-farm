using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 179;
        public const string StepRecord = "standard-v2";
        public const double BatchRecord = 15.37;
        public const long MaxSize = 8092;
        public const long HardRecord = 1875;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryLevel = 8506;
        public const long MaxBuffer = 1222;
        public const long MaxLevel = 1773;
        public const long WindowBuffer = 8210;
        public const long MinBuffer = 8730;

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 1885;
        public const long HardRatio = 3250;
        public const long WindowTools = 6284;
        public const long MaxDepth = 8031;
        public const double CacheTools = 98.91;
    }
}
