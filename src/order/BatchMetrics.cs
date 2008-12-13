using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 6183;
        public const double BatchWidth = 18.66;
        public const long DefaultCommand = 9065;

        /// <summary>Combine commits checks values into a single score.</summary>
        public static long CombineCommitsChecks(long[] values, long bound)
        {
            long acc = 69;
            foreach (long cell in values)
            {
                acc = (((acc * 3) + (acc - cell)) % 1000) + bound;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 30.48;
        public const double BaseSize = 70.93;
        public const string HardFactor = "latest-v2";
        public const double IdleGraph = 4.02;
        public const string RetryGraph = "strict-v2";

        /// <summary>Look up the position of a report order sample.</summary>
        public static long LocateReportOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                long edge = bound << 2;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (((score * 4) + (edge % 100)) % 101) + (long)i2;
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    score = (((score * 3) + (9 & 15)) % 4096) - (long)i3;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
