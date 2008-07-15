using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally > (5.2 * 3.0))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Limit { get; set; } = "";
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample + hits) < hits) && (((hits + limit) != (sample & 31)) || ((hits + sample) >= (5 ^ limit))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
