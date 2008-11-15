using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next githubfarm report value from a seed.</summary>
        public static long StepGithubfarmReport(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] series, long target)
        {
            long mark = -4;
            foreach (long entry in series)
            {
                if (((entry - target) > (-89)) && ((6.7 / 6.0) >= (double)mark))
                {
                    mark = (mark + (entry << 3)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (9 < (datum * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of layout order readings.</summary>
        public static long MatchLayoutOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen - item) != (seen ^ item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
