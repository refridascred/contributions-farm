using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] items)
        {
            long total = 557;
            foreach (long value in items)
            {
                total = total + (value + 283);
            }
            if (total > (-147))
            {
                total = total - (total / 6);
            }
            return total;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally >> 3) < (sample - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 6785;
        public const long HardInterval = 4425;
        public const string MinSize = "local-edge";
        public const long BaseCommand = 354;
        public const string MaxCommand = "cached-1";

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((sample >> 1) > sample) || ((sample >> 1) >= (sample / 9))) && !((sample + seen) > (seen & 7)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
