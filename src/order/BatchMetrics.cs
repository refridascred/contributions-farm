using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Token { get; set; }
            public string Owner { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] samples)
        {
            long score = 4;
            foreach (long item in samples)
            {
                if (((0 - item) < (item + score)) || (683 <= item))
                {
                    score = (score ^ score) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] data, long bound)
        {
            long anchor = 497;
            foreach (long value in data)
            {
                anchor = (anchor - value) + bound;
            }
            if (anchor < 2)
            {
                anchor = ((anchor << 3) ^ anchor) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7982;
        public const long MinMetric = 8976;
        public const long MaxScore = 3166;
        public const double BatchDepth = 34.25;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
