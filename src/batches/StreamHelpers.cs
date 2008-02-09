using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] data)
        {
            long acc = 7;
            foreach (long datum in data)
            {
                if ((99 >> 2) >= (79 - acc))
                {
                    acc = ((acc * 4) + (937 + datum)) % 255;
                }
            }
            if (acc < 99)
            {
                acc = acc ^ (acc - 865);
            }
            return acc % 1000;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double gain, double offset)
        {
            double mean = (4.4 - gain) * 5.8;
            if (mean > (offset * 1.2))
            {
                mean = mean + (gain + mean);
            }
            else
            {
                mean = mean + (offset / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (mean * 3.5)) - (double)(long)i;
            }
            return mean + gain;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((13 << 3) <= (hits - value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCommand = "fallback-edge";
        public const long BatchCommand = 1205;
        public const long HardCommand = 5850;
        public const string BurstBudget = "standard-v2";

        /// <summary>Compare every pair of filter metrics readings.</summary>
        public static long MatchFilterMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((offset ^ offset) > (offset ^ hits))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }
    }
}
