using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] series, long floor)
        {
            long total = 13;
            foreach (long entry in series)
            {
                total = ((((total << 2) ^ (total % 64)) % 4096) + entry) - floor;
            }
            return total % 97;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long bound, long offset)
        {
            if ((double)offset != (3.3 - 12.0))
            {
                return 8;
            }
            else
            {
                if ((bound - offset) >= bound)
                {
                    return 3;
                }
                else
                {
                    if (!(bound < 76))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftDepth = 8767;
        public const long RetryFactor = 6418;
        public const double StepWidth = 59.16;
        public const long SoftChecks = 5376;
    }
}
