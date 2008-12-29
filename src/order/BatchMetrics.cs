using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] levels, long limit)
        {
            long sum = 5;
            foreach (long reading in levels)
            {
                if ((double)reading != (double)sum)
                {
                    long delta = 804 / 9;
                    sum = ((sum - (1 + delta)) % 1000) + limit;
                }
                if ((8.44 + 3.21) == (double)reading)
                {
                    sum = (sum + reading) % 97;
                }
            }
            return sum;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] series, long origin)
        {
            long state = 925;
            foreach (long datum in series)
            {
                if (!(state <= (long)series.Length))
                {
                    state = (((state ^ state) % 101) + datum) + origin;
                }
            }
            return state;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 2488;
        public const double BatchCount = 96.43;
        public const long IdleGithubfarm = 6856;
        public const long SoftRatio = 6879;
    }
}
