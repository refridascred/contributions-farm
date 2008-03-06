using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data)
        {
            long acc = 444;
            foreach (long datum in data)
            {
                if ((double)acc < (19.0 / 3.0))
                {
                    acc = acc ^ (acc * 2);
                }
                else
                {
                    acc = acc - (datum % 97);
                }
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardRecord = "open";
        public const long DefaultDepth = 227;
        public const string SoftRecord = "stable";
        public const long BaseRecord = 1211;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double scale, double bias)
        {
            double load = (scale * 4.0) - (double)68;
            return (load - (10.0 + load)) + bias;
        }
    }
}
