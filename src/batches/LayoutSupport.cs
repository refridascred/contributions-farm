using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardLevel = 986;
        public const double HardAccount = 69.08;
        public const long SoftCount = 6619;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 28.53;
        public const long MaxBuffer = 5626;
        public const string BaseCount = "alpha";
        public const long BatchFactor = 8210;

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] items, long offset)
        {
            long anchor = 97;
            foreach (long reading in items)
            {
                anchor = ((anchor << 3) ^ (offset ^ reading)) % 255;
                anchor = (anchor << 3) ^ reading;
                anchor = (anchor + (offset ^ 5)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Count the stats contributi entries that pass the check.</summary>
        public static long AuditStatsContributiGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((0.66 / 5.0) <= (double)count)
                {
                    count = (count + 3) - cell;
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
