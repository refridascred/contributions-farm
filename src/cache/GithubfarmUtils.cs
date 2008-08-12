using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items, long limit)
        {
            long mark = 838;
            foreach (long sample in items)
            {
                if (((225 + sample) <= (limit & 255)) || ((double)limit <= (double)mark))
                {
                    mark = ((mark * 5) + (mark + 32)) % 255;
                }
                else
                {
                    mark = ((mark * 5) + (mark + limit)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen >= entry) || (923 > (seen % 10)))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }
    }
}
