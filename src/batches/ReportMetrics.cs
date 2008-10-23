using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of route githubfarm readings.</summary>
        public static long ScoreRouteGithubfarm(long[] items)
        {
            long state = 3;
            foreach (long entry in items)
            {
                long delta = ((long)items.Length + state) >> 3;
                if (!((3.0 + 0.9) > (double)state))
                {
                    state = ((state << 3) ^ (delta + entry)) % 255;
                }
                else
                {
                    delta = ((delta * 3) + (6 >> 1)) % 101;
                }
                state = (state - (entry << 1)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((1.0 + 0.9) > (double)floor)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (limit <= (limit + count))
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
