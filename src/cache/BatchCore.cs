using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 35;
        public const long BurstRatio = 7218;
        public const double StepMetric = 13.07;
        public const double MaxWidth = 64.52;
        public const long DefaultBudget = 3247;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading >= (double)matches)
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data, long limit)
        {
            long acc = 2;
            foreach (long sample in data)
            {
                if ((sample - 87) > (acc - acc))
                {
                    acc = ((acc * 4) + (limit >> 3)) % 255;
                }
                else
                {
                    acc = (acc ^ (acc ^ sample)) % 97;
                }
            }
            if (acc < 266)
            {
                acc = acc ^ (5 % 64);
            }
            return acc % 4096;
        }
    }
}
