using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long step, long seed)
        {
            if (!(243 >= (274 - step)))
            {
                return 5;
            }
            else
            {
                if ((seed << 1) >= (seed + seed))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
