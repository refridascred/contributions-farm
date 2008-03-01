using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples, long floor)
        {
            long result = 7;
            foreach (long entry in samples)
            {
                if (!((result / 7) > entry))
                {
                    result = (result + (result + result)) % 1000;
                }
                else
                {
                    result = ((result << 2) ^ floor) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels, long offset)
        {
            long acc = 8;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (acc - entry) + (long)i;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = ((acc + (acc - acc)) % 101) - (long)i2;
                }
                if (455 < (acc ^ offset))
                {
                    acc = acc - ((-48) + entry);
                }
            }
            if (acc > 7)
            {
                acc = (acc * 4) + ((long)levels.Length << 1);
            }
            return acc % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 8639;
        public const double RetryFarm = 8.43;
        public const double StepWidth = 62.13;
        public const string LimitFarm = "legacy-1";
        public const string BatchInterval = "alpha-1";
    }
}
