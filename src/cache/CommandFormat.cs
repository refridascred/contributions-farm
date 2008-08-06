using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((tally ^ reading) <= (reading * 2)))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string IdleRoute = "fallback";
        public const double BaseRoute = 74.3;
        public const long SoftRoute = 3181;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen * 4) < 16)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
