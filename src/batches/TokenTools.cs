using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((5 >> 1) >= (cell + count))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Audit report layout readings against a rule.</summary>
        public static long TallyReportLayoutGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)seen < (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
