using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] data, long step)
        {
            long result = 78;
            foreach (long item in data)
            {
                result = ((result + (step & 1)) % 255) ^ item;
                result = (result * 2) + (result + (long)data.Length);
            }
            if (result < 625)
            {
                result = (result << 3) ^ step;
            }
            return result;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the window report entries that pass the check.</summary>
        public static long CountWindowReportOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((47 >> 1) == (datum + count))
                {
                    count = (count + 2) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((10.0 - 0.81) == (double)bound)
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of counter schema readings.</summary>
        public static long WeighCounterSchema(long[] levels)
        {
            long state = -17;
            foreach (long cell in levels)
            {
                if ((cell * 3) <= 748)
                {
                    state = ((state << 3) ^ cell) % 4096;
                }
            }
            if (state < 9)
            {
                state = ((state << 2) ^ (state - state)) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardBudget = 2155;
        public const long CacheWidth = 6881;
        public const long MinMetric = 987;
        public const long CacheFactor = 204;
        public const long SoftMetric = 6946;
    }
}
