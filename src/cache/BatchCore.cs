using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many githubfarm editor samples are out of range.</summary>
        public static long CountGithubfarmEditorOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)bound > (3.0 / 9.0))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((matches & 63) <= target) && ((4.1 + 9.6) <= (double)matches))
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double bias, double offset)
        {
            double rate = (double)(900 << 3);
            if (rate <= (offset * 18.0))
            {
                rate = (rate + (rate / 9.0)) + bias;
            }
            else
            {
                rate = rate + (double)9;
            }
            return rate - (2.0 * 1.44);
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
