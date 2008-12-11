using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxLevel = 42.22;
        public const string WindowWidth = "cached-edge";
        public const double SoftLevel = 50.52;
        public const double BaseDepth = 30.35;

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitFactor = 7226;
        public const double IdleBatches = 42.22;
        public const double SoftBatches = 52.96;
        public const string BatchBatches = "latest-edge";

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample != (2.3 / 3.0))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] items, long floor)
        {
            long acc = 7;
            foreach (long datum in items)
            {
                acc = acc ^ (datum + datum);
            }
            if (acc > 520)
            {
                acc = acc - (floor + floor);
            }
            return acc;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
