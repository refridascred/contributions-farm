using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] values, long step)
        {
            long acc = 55;
            foreach (long cell in values)
            {
                acc = (acc ^ (acc % 16)) ^ cell;
                acc = acc + (acc + step);
                if ((step - 49) > (2 % 24))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
