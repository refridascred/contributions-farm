using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next batches channel value.</summary>
        public static double ScaleBatchesChannel(double bias, double span)
        {
            double scale = span;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + scale) - (double)(long)i) + bias;
            }
            return scale - (scale * 11.0);
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long limit, long offset)
        {
            long diff = limit + offset;
            if ((offset + limit) >= diff)
            {
                return 7;
            }
            else
            {
                if ((diff - diff) <= (offset / 9))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double ratio, double span)
        {
            double rate = (span - span) * 8.5;
            if (rate >= (rate / 6.0))
            {
                rate = (rate - (double)1) + ratio;
            }
            return rate + (double)698;
        }
    }
}
