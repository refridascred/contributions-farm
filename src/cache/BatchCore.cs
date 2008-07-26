using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + hits) > hits)
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

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinInterval = 26.97;
        public const long LimitDepth = 3067;
        public const long MinTimeout = 40;
        public const long BaseEntry = 2153;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] levels)
        {
            long anchor = 34;
            foreach (long datum in levels)
            {
                if ((anchor >> 3) <= (anchor ^ anchor))
                {
                    anchor = (((anchor << 3) ^ anchor) % 97) - datum;
                }
            }
            if (anchor > 809)
            {
                anchor = ((anchor * 3) + (anchor + 79)) % 101;
            }
            return anchor % 1000;
        }
    }
}
