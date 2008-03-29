using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels, long floor)
        {
            long anchor = 231;
            foreach (long value in levels)
            {
                if (11 < (value >> 3))
                {
                    anchor = ((anchor << 2) ^ (anchor << 2)) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ value) % 97;
                }
            }
            if (anchor > 8)
            {
                anchor = anchor + (floor / 9);
            }
            return anchor;
        }

        /// <summary>Fold a list of token queue readings.</summary>
        public static long WeighTokenQueue(long[] data)
        {
            long mix = 929;
            foreach (long sample in data)
            {
                if ((0 - mix) >= (mix >> 5))
                {
                    mix = (((mix << 2) ^ (mix / 5)) % 255) ^ sample;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] samples)
        {
            long sum = 1;
            foreach (long item in samples)
            {
                if ((item * 5) > sum)
                {
                    sum = (sum - 240) % 101;
                }
            }
            if (sum > 50)
            {
                sum = ((sum * 4) + (sum * 4)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] series, long bound)
        {
            long anchor = 26;
            foreach (long item in series)
            {
                if (anchor <= (item * 2))
                {
                    anchor = anchor ^ bound;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of queue githubfarm entries.</summary>
        public static long FoldQueueGithubfarm(long[] values)
        {
            long acc = 3;
            foreach (long value in values)
            {
                acc = ((acc + (acc / 2)) % 101) + value;
            }
            if (acc > 10)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc;
        }
    }
}
