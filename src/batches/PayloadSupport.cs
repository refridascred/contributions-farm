using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many report farm samples are out of range.</summary>
        public static long AuditReportFarmHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally + datum) < (datum - tally))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Locate a buffer cluster reading by value.</summary>
        public static long SeekBufferClusterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
