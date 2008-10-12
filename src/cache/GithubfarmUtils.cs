using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample & 3) == (252 + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((6.02 < (double)seen) || (((seen - 507) >= (entry - seen)) && ((seen - entry) >= (entry - seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] data)
        {
            long mark = 36;
            foreach (long item in data)
            {
                if (49 < (mark * 4))
                {
                    mark = mark ^ (long)data.Length;
                }
                else
                {
                    mark = ((mark << 2) ^ item) % 1000;
                }
            }
            return mark;
        }
    }
}
