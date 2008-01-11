using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftLevel = 2754;
        public const long WindowBatch = 5642;
        public const string BaseBatch = "standard";

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!(sample < ((long)series.Length & 7)) && (((long)series.Length + count) > (8 - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] values, long offset)
        {
            long sum = 6;
            foreach (long reading in values)
            {
                if (!(((long)values.Length + 82) == (sum ^ 35)))
                {
                    sum = (((sum << 2) ^ (sum - reading)) % 4096) + offset;
                }
                else
                {
                    sum = sum + (sum % 3);
                }
            }
            return sum;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double ratio = (double)33 - 7.9;
            if (ratio > ratio)
            {
                ratio = ((ratio - (ratio / 2.0)) - gain) + span;
            }
            else
            {
                ratio = ratio + 5.8;
            }
            return ratio + ratio;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitScore = 7778;
        public const double BurstWindow = 81.41;
        public const long SoftWindow = 2665;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Failed,
            Pending,
            Dropped,
        }
    }
}
