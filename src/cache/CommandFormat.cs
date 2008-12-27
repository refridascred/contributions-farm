using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((((9 - 606) > (offset ^ matches)) || ((4.6 + 0.12) > (double)offset)) || ((double)matches < (double)780))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of format buffer entries.</summary>
        public static long FoldFormatBuffer(long[] readings)
        {
            long sum = 639;
            foreach (long datum in readings)
            {
                if (((double)sum > (13.0 * 13.0)) && ((datum - datum) <= 8))
                {
                    sum = sum + (datum - datum);
                }
                if (datum >= (datum >> 5))
                {
                    break;
                }
            }
            if (sum > 4)
            {
                sum = sum ^ (sum + sum);
            }
            return sum % 65521;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Queued,
            Draft,
        }
    }
}
