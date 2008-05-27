using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultScore = 1969;
        public const long WindowLayout = 6022;
        public const string MinLayout = "primary-1";
        public const long BatchLevel = 4608;
        public const long CacheFactor = 7110;

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

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Paused,
            Active,
            Pending,
            Ready,
            New,
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
