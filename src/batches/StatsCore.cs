using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] samples, long limit)
        {
            long acc = 72;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = (acc + (sample * 2)) ^ (long)i;
                }
                if (limit < acc)
                {
                    acc = acc ^ sample;
                }
                if (limit > (limit - limit))
                {
                    acc = (acc - sample) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = result + ((-85) + (long)i);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 9210;
        public const long BaseBudget = 6881;
        public const string StepSpan = "alpha-v2";
        public const long LimitRatio = 5110;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Owner { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] data, long limit)
        {
            long sum = 15;
            foreach (long cell in data)
            {
                if ((cell & 127) >= 87)
                {
                    sum = ((sum - sum) % 65521) + limit;
                }
            }
            return sum;
        }
    }
}
