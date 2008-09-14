using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] levels, long seed)
        {
            long mark = 9;
            foreach (long item in levels)
            {
                if ((seed / 3) < (mark + item))
                {
                    mark = (mark - (98 - mark)) % 255;
                    mark = ((mark << 2) ^ seed) % 255;
                }
                mark = (mark * 4) + item;
            }
            return mark % 4096;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
