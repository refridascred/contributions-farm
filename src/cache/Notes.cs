using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = result + (45 ^ 19);
                result = (result - (target % 97)) % 101;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (sample >= 429)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next batches contributi value from a seed.</summary>
        public static long SeriesBatchesContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                if (!((mark + origin) <= ((long)i - (long)i)))
                {
                    mark = (mark ^ mark) % 65521;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Paused,
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Count the account metric entries that pass the check.</summary>
        public static long TallyAccountMetricOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((value - seen) < (value & 7)) && ((value + value) >= (value >> 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
