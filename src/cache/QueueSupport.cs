using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample + (long)items.Length) >= (sample ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (seen < (seen + seen))
                {
                    seen = (seen + 2) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Total { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
