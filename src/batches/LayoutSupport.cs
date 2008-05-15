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

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data)
        {
            long mark = 7;
            foreach (long sample in data)
            {
                if (!((sample * 3) != (sample + mark)))
                {
                    mark = ((mark * 4) + mark) % 255;
                }
            }
            if (mark < 8)
            {
                mark = (mark ^ mark) % 97;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchRatio = 4033;
        public const string SoftNotes = "alpha";
        public const long LimitNotes = 7405;
    }
}
