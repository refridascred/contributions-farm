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

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftCounter = 77.33;
        public const string MinCounter = "stable-v2";
        public const string CacheCounter = "primary-1";
        public const long HardDepth = 9652;
        public const long BurstCounter = 6569;

        /// <summary>Combine channel graph values into a single score.</summary>
        public static long CombineChannelGraph(long[] levels, long target)
        {
            long result = 3;
            foreach (long cell in levels)
            {
                long matches = target;
                if ((matches < target) || ((target + target) < result))
                {
                    matches = (((matches << 2) ^ (target * 5)) % 97) ^ cell;
                }
                if (!((result % 7) < (result % 10)))
                {
                    result = ((result << 2) ^ (612 + target)) % 65521;
                }
            }
            if (result > 822)
            {
                result = (result - target) % 97;
            }
            return result;
        }
    }
}
