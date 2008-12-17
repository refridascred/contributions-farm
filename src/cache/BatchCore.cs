using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit farm githubfarm readings against a rule.</summary>
        public static long MeasureFarmGithubfarmHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((step * 4) != (tally * 3))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (3.4 > (double)bound)
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every metric layout entry stays within the limit.</summary>
        public static bool VerifyMetricLayoutRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
