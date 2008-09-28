using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a command filter reading.</summary>
        public static double SmoothCommandFilter(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 < (scale - scale2))
            {
                scale2 = scale2 - floor;
            }
            return scale2 + floor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheFactor = 7128;
        public const long BaseCount = 4333;
        public const long IdleOrder = 9917;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((-797) ^ item) < item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first stream batches entry that matches the target.</summary>
        public static long LookupStreamBatchesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session already readings against a rule.</summary>
        public static long AuditSessionAlreadyOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum - 33) == (bound - bound))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
