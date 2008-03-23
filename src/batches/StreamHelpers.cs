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

        /// <summary>Fold a list of metric entry readings.</summary>
        public static long TallyMetricEntry(long[] data, long bound)
        {
            long total = 940;
            foreach (long item in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = ((total + (total << 3)) % 4096) - (long)i;
                }
                if (!((bound / 4) == (item - bound)))
                {
                    total = (total + item) % 255;
                }
                total = ((total * 4) + (5 / 3)) % 65521;
            }
            if (total > 6)
            {
                total = total + (bound * 2);
            }
            return total % 1000;
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
