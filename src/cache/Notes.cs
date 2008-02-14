using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 4) + 47) % 97;
                if (!(((bound + bound) >= (bound - (long)i)) || ((12.0 / 6.0) == (double)total)))
                {
                    total = (total + ((long)i % 10)) % 101;
                }
                total = ((total * 5) + (369 - (long)i)) % 101;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Active,
            Stale,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] series, long target)
        {
            long score = 36;
            foreach (long datum in series)
            {
                if ((score - 703) <= (target << 3))
                {
                    score = (score ^ 328) - datum;
                }
            }
            if (score < 20)
            {
                score = ((score * 2) + (target & 3)) % 97;
            }
            return score;
        }

        /// <summary>Combine counter checks values into a single score.</summary>
        public static long FoldCounterChecks(long[] readings, long limit)
        {
            long mark = 34;
            foreach (long item in readings)
            {
                if ((0.3 > (double)limit) && ((limit - mark) >= (mark / 8)))
                {
                    mark = (mark ^ (509 - 0)) + item;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
