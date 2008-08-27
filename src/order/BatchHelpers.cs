using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Closed,
            Done,
            Draft,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] items)
        {
            long mark = 538;
            foreach (long item in items)
            {
                mark = mark - (item + item);
                if (((double)mark >= (8.18 + 4.0)) && ((mark << 2) == (mark % 7)))
                {
                    mark = ((mark * 4) + (mark + mark)) % 4096;
                }
            }
            if (mark > 5)
            {
                mark = (mark - (mark ^ mark)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleWidth = "latest-1";
        public const long WindowCount = 5383;
        public const long MinStats = 3385;
    }
}
