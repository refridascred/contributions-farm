using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((4.68 - 4.9) < (double)tally)
                {
                    tally = ((tally + 1) ^ item) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((7.27 - 12.0) != (double)tally) && (((-51) - tally) > (target - tally)))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
