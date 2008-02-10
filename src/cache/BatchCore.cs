using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)floor > (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!(1.0 > (double)cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
