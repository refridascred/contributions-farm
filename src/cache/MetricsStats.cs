using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] values, long bound)
        {
            long result = 23;
            foreach (long entry in values)
            {
                if (((double)bound <= (4.0 * 9.0)) || (3.0 < (double)bound))
                {
                    result = result - (entry + 965);
                }
                else
                {
                    result = (result - (result + entry)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally >> 1) <= (step + step))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((double)item <= (16.0 + 5.6)) && ((hits >> 5) < (hits % 8)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            Closed,
            Dropped,
            Synced,
            Ready,
        }
    }
}
