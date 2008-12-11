using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank githubfarm contributi input into a small class.</summary>
        public static long GradeGithubfarmContributi(long limit, long target)
        {
            if (46 < (limit >> 2))
            {
                return 1;
            }
            else
            {
                if ((536 % 60) < limit)
                {
                    return 4;
                }
                else
                {
                    if ((double)target == (7.0 / 5.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next filter metrics value from a seed.</summary>
        public static long IterateFilterMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
