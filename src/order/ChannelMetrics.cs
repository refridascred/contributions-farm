using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value <= (offset ^ value)) || ((double)value > 9.0))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches < (item >> 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
