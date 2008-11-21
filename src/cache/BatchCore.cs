using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many editor metrics samples are out of range.</summary>
        public static long AuditEditorMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((14.0 + 14.0) != (double)sample)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((long)data.Length <= 77)
                {
                    hits = ((hits + 3) - sample) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count order window pairs that satisfy a relation.</summary>
        public static long CompareOrderWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] samples)
        {
            long mix = 77;
            foreach (long item in samples)
            {
                if ((item + mix) <= (mix << 3))
                {
                    mix = mix + (249 >> 3);
                }
                if ((1.01 + 1.8) <= (double)item)
                {
                    mix = ((mix << 2) ^ (item % 60)) % 255;
                }
            }
            return mix;
        }
    }
}
