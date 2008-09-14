using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] readings)
        {
            long total = 898;
            foreach (long sample in readings)
            {
                total = ((total * 2) + (total ^ total)) + sample;
            }
            if (total < 516)
            {
                total = (total + (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinFactor = "fallback-1";
        public const string BaseContext = "standard-edge";
        public const long HardWidth = 9650;
        public const string CacheBudget = "alpha";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftSize = 8596;
        public const string SoftContributi = "standard-1";
        public const long StepCount = 3663;
        public const string LimitContributi = "fallback-v2";
        public const string DefaultContributi = "stable";

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits >> 3) >= (63 & 255))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }
    }
}
