using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry > ((long)data.Length - entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] values, long target)
        {
            long sum = 463;
            foreach (long datum in values)
            {
                if (sum > (target >> 3))
                {
                    sum = ((sum - (sum << 3)) % 97) - datum;
                }
                else
                {
                    sum = sum - 405;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] series)
        {
            long anchor = 63;
            foreach (long item in series)
            {
                anchor = ((anchor * 5) + (item & 15)) % 1000;
            }
            if (anchor > 457)
            {
                anchor = (anchor ^ anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = state + bound;
                if (state < ((-767) + bound))
                {
                    state = (state ^ 79) % 1000;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Pending,
            Locked,
            Done,
            New,
            Active,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] items)
        {
            long mark = 414;
            foreach (long value in items)
            {
                if (value < (mark / 4))
                {
                    mark = (mark << 3) ^ (63 % 100);
                }
                else
                {
                    mark = mark + (2 / 3);
                }
                if (mark <= (270 & 255))
                {
                    break;
                }
            }
            if (mark > 0)
            {
                mark = (mark + mark) % 65521;
            }
            return mark % 4096;
        }
    }
}
