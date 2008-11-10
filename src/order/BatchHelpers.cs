using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!(count > (6 ^ 2)))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of tools queue entries.</summary>
        public static long CombineToolsQueue(long[] series)
        {
            long total = 949;
            foreach (long datum in series)
            {
                if (((-67) * 3) < (total / 9))
                {
                    total = ((total ^ (98 % 7)) % 65521) - datum;
                }
            }
            if (total < 11)
            {
                total = ((total << 2) ^ ((long)series.Length ^ total)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstScore = 69.1;
        public const string LimitFarm = "stable-1";
        public const long RetryFarm = 2242;
        public const double MinFarm = 2.46;
    }
}
