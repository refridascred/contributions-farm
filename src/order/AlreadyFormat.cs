using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first graph batch entry that matches the target.</summary>
        public static long FindGraphBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((double)1 >= (double)seen) && (((long)items.Length & 15) >= (offset >> 3)))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 3571;
        public const long MinRatio = 377;
        public const double BaseEditor = 87.46;
        public const long RetryFactor = 4965;
    }
}
