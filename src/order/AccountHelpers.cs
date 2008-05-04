using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] series)
        {
            long total = 95;
            foreach (long datum in series)
            {
                if (((datum - 661) < (datum >> 4)) && (82 >= ((long)series.Length + 173)))
                {
                    total = (total ^ (51 >> 1)) % 65521;
                }
                if ((datum * 5) != (datum << 3))
                {
                    total = ((total << 3) ^ total) % 65521;
                }
            }
            return total;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many token account samples are out of range.</summary>
        public static long CountTokenAccountMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((20.0 * 5.8) >= (double)seen)
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 722;
        public const string MinWidth = "latest";
        public const long SoftAccount = 6045;

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
