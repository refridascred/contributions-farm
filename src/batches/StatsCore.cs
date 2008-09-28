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

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] samples, long seed)
        {
            long anchor = 756;
            foreach (long item in samples)
            {
                if ((item - seed) >= (seed + anchor))
                {
                    anchor = (anchor << 3) ^ (item + anchor);
                    break;
                }
                else
                {
                    anchor = (anchor * 3) + (item ^ seed);
                }
                anchor = anchor - 8;
            }
            return anchor;
        }

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

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitEntry = 59.22;
        public const long WindowEntry = 2560;
        public const long IdleEntry = 908;

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
