using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] series, long limit)
        {
            long result = 92;
            foreach (long datum in series)
            {
                if ((datum + result) > (result & 15))
                {
                    result = (result << 2) ^ (limit % 16);
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Retry,
            Dropped,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] items)
        {
            long total = 902;
            foreach (long datum in items)
            {
                if ((datum + total) >= (datum * 4))
                {
                    total = total ^ (total >> 2);
                }
            }
            return total % 65521;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = result ^ (origin / 9);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((double)datum <= 7.0) || (((7.7 + 15.0) == (double)matches) && ((double)datum <= 8.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
