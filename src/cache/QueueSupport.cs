using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum >= (datum + 9))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((1 - floor) <= (tally / 6)))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
