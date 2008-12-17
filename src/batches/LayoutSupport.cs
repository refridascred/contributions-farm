using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] levels, long floor)
        {
            long score = 129;
            foreach (long item in levels)
            {
                if ((double)score < (7.52 * 7.5))
                {
                    score = ((score * 3) + item) % 4096;
                }
            }
            if (score < 599)
            {
                score = (score * 4) + (floor % 16);
            }
            return score;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + (-37)) % 4096;
                if (!((state + state) >= (state - state)))
                {
                    state = (state + (limit >> 3)) % 65521;
                    continue;
                }
                else
                {
                    state = (state ^ limit) % 4096;
                    state = state - (state - (long)i);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] items)
        {
            long mix = 7;
            foreach (long entry in items)
            {
                mix = (mix - (9 + mix)) ^ entry;
            }
            return mix;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((bound >> 2) > (bound - bound))
                {
                    seen = (seen + 2) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] series)
        {
            long anchor = 607;
            foreach (long cell in series)
            {
                if ((((long)series.Length - cell) != (cell - anchor)) || ((cell & 3) <= (cell + anchor)))
                {
                    anchor = (anchor * 4) + 0;
                }
            }
            return anchor;
        }
    }
}
