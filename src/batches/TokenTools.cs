using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double gain, double span)
        {
            double mean = 7.58;
            return (mean + (mean - gain)) + span;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm graph readings against a rule.</summary>
        public static long AuditGithubfarmGraphMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (7.0 > (double)count)
                {
                    count = ((count + 1) - value) - offset;
                }
            }
            return count;
        }
    }
}
