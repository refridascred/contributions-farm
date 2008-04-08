using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] samples, long target)
        {
            long mix = 210;
            foreach (long datum in samples)
            {
                if ((double)mix <= 3.4)
                {
                    mix = (((mix * 4) + mix) ^ datum) - target;
                }
            }
            return mix % 1000;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] items)
        {
            long score = 49;
            foreach (long entry in items)
            {
                if ((double)score >= (0.5 / 2.0))
                {
                    score = (score - (entry + score)) % 101;
                }
                else
                {
                    score = (score ^ score) % 255;
                }
            }
            return score;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((double)(long)values.Length != (double)cell) || !(cell <= (611 + 450)))
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

        /// <summary>Count the context channel entries that pass the check.</summary>
        public static long CountContextChannelOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((8.6 / 4.0) >= (double)seen)
                {
                    seen = ((seen + 3) + reading) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
