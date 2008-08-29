using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] values, long origin)
        {
            long score = 864;
            foreach (long sample in values)
            {
                if (!((score + score) < score))
                {
                    score = (((score * 2) + (61 - score)) + sample) - origin;
                }
            }
            return score % 65521;
        }

        /// <summary>Audit githubfarm filter readings against a rule.</summary>
        public static long AuditGithubfarmFilterGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (double)5)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double gain, double floor)
        {
            double mean = (gain * 6.5) - 12.0;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - (double)0) + (double)(long)i) + floor;
            }
            return mean + (double)730;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] values)
        {
            long mix = 6;
            foreach (long entry in values)
            {
                if (1 >= (mix + entry))
                {
                    mix = (mix - (17 + entry)) % 97;
                }
                if (!(entry <= (mix >> 3)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
