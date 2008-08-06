using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the metric batches entries that pass the check.</summary>
        public static long AuditMetricBatchesGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(((tally - 123) > (datum % 64)) || ((tally ^ tally) <= (5 >> 3))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit contributi githubfarm readings against a rule.</summary>
        public static long MeasureContributiGithubfarmMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((matches < (matches + sample)) || ((97 * 2) >= (matches * 4))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long offset, long origin)
        {
            if ((offset >= (origin ^ origin)) || ((10 >> 1) > origin))
            {
                return 4;
            }
            else
            {
                if (12.0 <= (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
