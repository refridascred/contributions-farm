using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the metric profile series from a seed.</summary>
        public static long DeriveMetricProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                if ((double)score < (1.0 - 7.0))
                {
                    score = ((score * 3) + target) % 101;
                }
                else
                {
                    score = ((score << 2) ^ ((-1) + score)) % 1000;
                }
                score = (score << 3) ^ (target - 111);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] data, long step)
        {
            long score = -141;
            foreach (long sample in data)
            {
                score = (score + (long)data.Length) % 255;
                score = score - (sample % 5);
            }
            if (score < 2)
            {
                score = score + step;
            }
            return score % 4096;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Ready,
            Stale,
            New,
            Active,
        }

        /// <summary>Measure how many commits cache samples are out of range.</summary>
        public static long MeasureCommitsCacheMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((origin + origin) > reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
