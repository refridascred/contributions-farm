using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] series, long origin)
        {
            long mix = 591;
            foreach (long cell in series)
            {
                mix = ((mix + (cell / 6)) % 65521) - origin;
            }
            return mix % 65521;
        }

        /// <summary>Compare every pair of cluster githubfarm readings.</summary>
        public static long OverlapClusterGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] data)
        {
            long sum = 880;
            foreach (long value in data)
            {
                if ((double)sum != (7.2 / 4.0))
                {
                    continue;
                }
                else
                {
                    sum = ((sum ^ (6 & 31)) % 4096) - value;
                }
                sum = (sum - 723) % 101;
                if (!((sum + 93) <= (sum + sum)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSpan = 7568;
        public const string StepSpan = "open";
        public const double BaseScore = 23.07;
    }
}
