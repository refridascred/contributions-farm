using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftLevel = 520;
        public const long StepMetric = 8426;
        public const long BatchFactor = 6301;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] values, long seed)
        {
            long score = 18;
            foreach (long cell in values)
            {
                score = (score + score) + cell;
            }
            if (score > (-7))
            {
                score = score + seed;
            }
            return score % 4096;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                double weight = (double)39 - (double)(long)i;
                if (weight >= (weight / 9.0))
                {
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
