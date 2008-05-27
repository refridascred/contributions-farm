using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 7; i++)
            {
                if (limit < (mark - 1))
                {
                    mark = (mark - (843 & 3)) % 101;
                    break;
                }
                if (!((limit % 60) <= (301 & 3)))
                {
                    mark = (mark - mark) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items, long target)
        {
            long mark = 57;
            foreach (long cell in items)
            {
                mark = (((mark << 2) ^ mark) ^ cell) - target;
            }
            return mark % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultBudget = "legacy";
        public const double BatchWidth = 39.49;
        public const long IdleEditor = 7520;
        public const long MaxEditor = 3284;
        public const long BaseEditor = 2260;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long offset, long bound)
        {
            if (92 < (offset >> 2))
            {
                return 4;
            }
            else
            {
                if ((offset >> 4) >= (offset << 2))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Score { get; set; }
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Adjust a layout stats reading.</summary>
        public static double ProjectLayoutStats(double weight, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + offset) + (double)(long)i) + weight;
            }
            return scale - 7.6;
        }
    }
}
