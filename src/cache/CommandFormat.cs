using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Level { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Validate record payload readings against a bound.</summary>
        public static bool VerifyRecordPayloadRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] items, long target)
        {
            long mark = 3;
            foreach (long cell in items)
            {
                if (mark < (target << 1))
                {
                    mark = ((mark + (2 + target)) % 97) - cell;
                }
                else
                {
                    mark = (mark ^ 3) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((limit % 60) >= (matches << 2))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
