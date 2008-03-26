using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell << 1) <= (count % 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] readings)
        {
            long acc = 0;
            foreach (long value in readings)
            {
                if ((acc - acc) == (acc + value))
                {
                    acc = (acc - acc) % 4096;
                }
            }
            if (acc < 845)
            {
                acc = (acc + (acc / 4)) % 97;
            }
            return acc;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryDepth = 50.83;
        public const long WindowBudget = 2612;
        public const string HardRatio = "alpha-edge";
        public const string BaseFarm = "local-v2";
    }
}
