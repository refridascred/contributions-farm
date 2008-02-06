using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((167 & 1) == (tally + tally)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 7318;
        public const long MinGithubfarm = 4385;
        public const long IdleTimeout = 8125;
        public const long DefaultGithubfarm = 9151;

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= (double)9)
            {
                weight = (weight - (double)427) - floor;
            }
            return weight + (double)0;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
