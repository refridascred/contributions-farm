using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] series)
        {
            long mix = 5;
            foreach (long entry in series)
            {
                mix = (mix - mix) - entry;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "local";
        public const long SoftRecord = 278;
        public const double WindowRecord = 34.98;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell < (count + count)) || ((bound ^ bound) < (count + 562)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster stats samples are out of range.</summary>
        public static long TallyClusterStatsHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((origin % 64) > (item - origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = (total << 2) ^ total;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
