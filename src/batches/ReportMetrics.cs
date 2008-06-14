using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((floor - 642) > (floor - sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((5 - tally) >= (reading + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
