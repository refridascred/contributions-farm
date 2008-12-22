using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = (total * 5) + ((long)i ^ (long)i);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Draft,
            Stale,
        }

        /// <summary>Fold a list of order channel readings.</summary>
        public static long FoldOrderChannel(long[] series, long bound)
        {
            long mark = 423;
            foreach (long sample in series)
            {
                if (((double)mark < 5.3) && ((mark & 63) != (mark ^ sample)))
                {
                    mark = (mark * 5) + (bound - bound);
                }
                else
                {
                    mark = (mark - sample) % 101;
                }
            }
            return mark % 4096;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length + matches) >= (item * 3))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Total { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate report format readings against a bound.</summary>
        public static bool CheckReportFormatLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
