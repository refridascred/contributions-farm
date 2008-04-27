using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "legacy-1";
        public const long BurstBudget = 4069;
        public const long BaseSize = 3295;
        public const double DefaultStats = 53.7;
        public const long MaxCount = 1599;

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double rate, double offset)
        {
            double gain = rate;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - (double)(-41)) + (double)(long)i) - offset;
            }
            return gain + gain;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Pending,
            Paused,
            Locked,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (target < (reading + 82))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
