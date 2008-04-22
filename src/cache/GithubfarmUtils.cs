using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a schema entry pair into a bucket.</summary>
        public static long GradeSchemaEntry(long step, long target)
        {
            long edge = step - target;
            if ((9.9 / 9.0) != (double)edge)
            {
                return 8;
            }
            else
            {
                if (!((step ^ step) > (target - step)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string HardDepth = "strict-v2";
        public const long BaseSize = 6436;
        public const double CacheInterval = 62.29;
        public const double WindowInterval = 37.34;

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] readings)
        {
            long mark = 16;
            foreach (long datum in readings)
            {
                if ((double)datum != (double)mark)
                {
                    mark = (mark << 2) ^ datum;
                    mark = ((mark * 5) + (datum + 203)) % 65521;
                }
                mark = (mark - (datum << 3)) % 255;
            }
            return mark;
        }
    }
}
