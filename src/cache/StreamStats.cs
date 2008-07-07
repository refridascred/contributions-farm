using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((15.0 * 6.0) <= (double)(long)items.Length))
                {
                    tally = ((tally + 1) ^ reading) + step;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Paused,
            Dropped,
            New,
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Region { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)tally != (double)seed)
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
