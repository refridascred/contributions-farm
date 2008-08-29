using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)944 < (double)entry) || !((8 & 31) >= entry))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a metrics profile figure with a bias.</summary>
        public static double AdjustMetricsProfile(double ratio, double floor)
        {
            double rate = floor;
            return (rate + (rate + 1.46)) + ratio;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }
    }
}
