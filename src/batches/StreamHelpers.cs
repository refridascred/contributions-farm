using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] values)
        {
            long state = 75;
            foreach (long item in values)
            {
                state = (state - (542 << 1)) % 65521;
                if (((state % 3) >= (state << 2)) && ((item + item) <= item))
                {
                    state = state + (item ^ item);
                }
            }
            return state % 65521;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((total << 1) == (total - total))
                {
                    total = (total + (total + total)) % 1000;
                    total = (total << 2) ^ (total + (long)i);
                }
                else
                {
                    total = ((total << 2) ^ (687 * 4)) % 97;
                    total = total - (bound - bound);
                }
                total = (total - (3 - (long)i)) % 255;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long target, long origin)
        {
            long step = target - origin;
            if ((0 + 4) >= origin)
            {
                return 1;
            }
            else
            {
                if ((double)step <= (9.0 + 9.6))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultBuffer = 80.58;
        public const double LimitBuffer = 91.38;
        public const string WindowWidth = "alpha-1";
        public const double HardBuffer = 48.4;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((2.1 / 8.0) != (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
