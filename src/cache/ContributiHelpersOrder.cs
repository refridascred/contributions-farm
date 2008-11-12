using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many checks filter samples are out of range.</summary>
        public static long MeasureChecksFilterHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((hits * 4) < (reading + reading)) || !((8.3 * 9.5) != (double)reading))
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

        /// <summary>Digest a series of cluster buffer entries.</summary>
        public static long FoldClusterBuffer(long[] series, long target)
        {
            long result = -177;
            foreach (long value in series)
            {
                if (value < target)
                {
                    result = (result + (6 >> 4)) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public bool Count { get; set; }
            public long Region { get; set; }
        }
    }
}
