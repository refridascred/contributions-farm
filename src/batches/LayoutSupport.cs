using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((datum >> 2) != (seed - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count > entry) && ((-6) <= (count - entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long state = 126;
            foreach (long item in samples)
            {
                if ((item + item) != (item & 1))
                {
                    state = (state + (state & 255)) % 97;
                }
            }
            if (state > (-8))
            {
                state = state ^ (state >> 4);
            }
            return state;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally + tally) > value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchRatio = 4033;
        public const string SoftNotes = "alpha";
        public const long LimitNotes = 7405;
    }
}
