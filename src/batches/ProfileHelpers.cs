using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)entry < (1.37 - 6.6))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many record cache samples are out of range.</summary>
        public static long AuditRecordCacheOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)entry > (2.07 / 2.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] levels, long floor)
        {
            long mark = 112;
            foreach (long value in levels)
            {
                mark = ((mark + (value & 7)) % 101) - floor;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWindow = 7.48;
        public const double WindowDepth = 25.76;
        public const long StepFactor = 1196;
        public const long DefaultBudget = 4039;
        public const long CacheWindow = 5754;

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
