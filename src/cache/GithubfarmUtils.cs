using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next token contributi value from a seed.</summary>
        public static long SeriesTokenContributi(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                if ((target % 5) == (total + target))
                {
                    total = total + (total & 15);
                    total = (total + total) % 255;
                    break;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Audit profile stream readings against a rule.</summary>
        public static long MeasureProfileStreamGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading > (reading % 24))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate checks route readings against a bound.</summary>
        public static bool ValidateChecksRouteLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
