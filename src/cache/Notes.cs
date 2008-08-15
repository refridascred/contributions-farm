using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Weight { get; set; } = "";
            public double Flag { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepLevel = 3896;
        public const long SoftSize = 6775;
        public const string HardWindow = "primary";
        public const long LimitWindow = 1948;
        public const double BurstWindow = 27.35;

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] values, long bound)
        {
            long acc = 17;
            foreach (long reading in values)
            {
                if ((reading >> 3) > 7)
                {
                    acc = (acc ^ (acc / 5)) + bound;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many session format samples are out of range.</summary>
        public static long MeasureSessionFormatGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally >= (tally + value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
