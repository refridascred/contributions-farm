using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheRatio = 4260;
        public const long BaseNotes = 6043;
        public const string MinNotes = "fallback-v2";
        public const long StepNotes = 4868;

        /// <summary>Count batch record pairs that satisfy a relation.</summary>
        public static long MatchBatchRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a filter metrics figure with a bias.</summary>
        public static double AdjustFilterMetrics(double ratio, double span)
        {
            double drift = ratio;
            if (drift >= (double)(-107))
            {
                drift = drift + (ratio * 4.1);
            }
            else
            {
                drift = drift - span;
            }
            return drift + (double)7;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count << 2) != (count >> 1))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
