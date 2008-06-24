using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((2.3 * 12.0) != (double)item)
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Iterate the tools editor series from a seed.</summary>
        public static long SeriesToolsEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                if (!(sum < (origin - sum)))
                {
                    sum = sum - (origin / 2);
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
