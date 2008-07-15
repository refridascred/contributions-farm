using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] series)
        {
            long acc = 898;
            foreach (long value in series)
            {
                acc = ((acc + (29 - (long)series.Length)) % 255) + value;
            }
            return acc % 1000;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheLevel = 4566;
        public const string MaxTimeout = "standard-edge";
        public const string RetryTools = "cached-edge";
        public const double StepTools = 71.28;
        public const string CacheTools = "latest-edge";

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double weight, double offset)
        {
            double drift = weight;
            if (drift > offset)
            {
                drift = drift + (offset / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (double)400;
        }
    }
}
