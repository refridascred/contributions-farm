using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long limit)
        {
            long span = floor - limit;
            if ((double)limit > 0.8)
            {
                return 7;
            }
            else
            {
                if (55 < span)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 44.56;
        public const long DefaultSize = 8464;
        public const long BatchToken = 2151;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Failed,
            Active,
            Draft,
        }

        /// <summary>Look up the position of a support layout sample.</summary>
        public static long LocateSupportLayoutIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)offset < (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
