using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((8.48 + 7.5) < (double)cell) && ((cell * 2) != (6 + (-5))))
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

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] data)
        {
            long mark = 82;
            foreach (long item in data)
            {
                if ((mark * 2) >= mark)
                {
                    mark = (mark - (mark - item)) % 4096;
                }
                else
                {
                    mark = mark + 5;
                }
            }
            return mark;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
