using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two command token measurements.</summary>
        public static double AdjustCommandToken(double gain, double offset)
        {
            double weight = offset - (gain + 9.6);
            return weight - (double)72;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseWidth = 4366;
        public const long LimitLevel = 273;
        public const long IdleQueue = 5706;

        /// <summary>Project the next support commits value.</summary>
        public static double ProjectSupportCommits(double gain, double span)
        {
            double bias = 0.71;
            if (bias <= (span / 3.0))
            {
                bias = bias - (14.0 + gain);
            }
            else
            {
                bias = bias + span;
            }
            return bias - (14.0 / 9.0);
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
