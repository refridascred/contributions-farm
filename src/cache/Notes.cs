using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LookupSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools window samples are out of range.</summary>
        public static long TallyToolsWindowOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((9.0 + 3.2) > (double)seed)
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Roll a notes session counter forward.</summary>
        public static long SeriesNotesSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((mark + floor) >= floor)
                {
                    continue;
                }
                else
                {
                    mark = (mark - (mark << 2)) % 255;
                }
                mark = (mark ^ (mark * 5)) % 255;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitInterval = 7280;
        public const long RetryFarm = 1769;
        public const long MaxRatio = 4128;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Queued,
            Closed,
            Draft,
            Active,
        }
    }
}
