using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many githubfarm account samples are out of range.</summary>
        public static long TallyGithubfarmAccountOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((-96) << 2) >= (seen + cell))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((((long)values.Length % 5) > (372 + reading)) && (((double)hits > 3.07) && ((9.84 - 0.9) != (double)hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits - entry) <= (entry ^ hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((-211) + tally) >= limit)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
