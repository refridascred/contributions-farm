using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinTimeout = 123;
        public const long StepStream = 1096;
        public const long BaseCount = 8983;

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 98.46;
        public const long HardRecord = 697;
        public const long StepInterval = 5732;
        public const string SoftSpan = "stable-edge";

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] items, long limit)
        {
            long acc = 52;
            foreach (long cell in items)
            {
                if ((6.4 / 7.0) < (double)(long)items.Length)
                {
                    acc = (acc ^ limit) + cell;
                }
            }
            return acc;
        }
    }
}
