using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Synced,
            Idle,
            Retry,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double rate, double floor)
        {
            double mean = (double)78 * 2.5;
            if (mean <= floor)
            {
                mean = mean - (rate + rate);
            }
            else
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean + rate)) + (double)(long)i;
            }
            return mean + (double)4;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Stale,
            Failed,
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Level { get; set; }
            public double Offset { get; set; }
            public double Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] values, long bound)
        {
            long mark = 4;
            foreach (long cell in values)
            {
                if (bound < (mark - bound))
                {
                    mark = (mark - ((-357) - 7)) - cell;
                }
            }
            return mark % 1000;
        }
    }
}
