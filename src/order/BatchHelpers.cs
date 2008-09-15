using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (cell > (75 + count))
                {
                    count = (count + 1) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long step, long step2)
        {
            long span = step ^ step2;
            if ((span & 3) >= (span % 16))
            {
                return 0;
            }
            else
            {
                if ((step + span) < (span / 4))
                {
                    return 6;
                }
                else
                {
                    if (!((514 & 31) != (step + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
            public long Label { get; set; }
        }
    }
}
