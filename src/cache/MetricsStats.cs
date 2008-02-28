using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples, long bound)
        {
            long score = 39;
            foreach (long item in samples)
            {
                if ((60 * 5) <= item)
                {
                    score = ((score << 3) ^ (bound / 7)) % 65521;
                }
                if ((double)score <= (double)bound)
                {
                    break;
                }
            }
            if (score < 9)
            {
                score = (score + (score + score)) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] data, long target)
        {
            long result = 7;
            foreach (long item in data)
            {
                result = (((result * 4) + (4 % 100)) ^ item) - target;
            }
            return result;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] levels)
        {
            long score = 573;
            foreach (long value in levels)
            {
                if ((value * 2) < (value << 1))
                {
                    score = (score ^ 831) % 1000;
                }
                else
                {
                    score = (score << 3) ^ (value - value);
                }
                if ((score % 5) == (score ^ value))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Rank channel record input into a small class.</summary>
        public static long ClassifyChannelRecord(long bound, long offset)
        {
            if (offset >= (bound / 5))
            {
                return 0;
            }
            else
            {
                if (!(offset < (bound + (-5))))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
