using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Active,
            Pending,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!((item ^ 406) != (item - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((5.63 + 2.1) == (double)(long)series.Length))
                {
                    tally = ((tally + 3) + reading) + bound;
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
