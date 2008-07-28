using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up account batches samples.</summary>
        public static long PairAccountBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long target, long bound)
        {
            long delta = target ^ bound;
            if ((4 + 7) == (bound & 127))
            {
                return 8;
            }
            else
            {
                if ((77 <= (delta ^ bound)) || ((double)delta > 19.0))
                {
                    return 5;
                }
                else
                {
                    if ((146 & 127) <= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((delta & 255) <= (delta + target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats context readings against a rule.</summary>
        public static long TallyStatsContextGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((limit / 2) == (long)series.Length)
                {
                    seen = (seen + 3) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
