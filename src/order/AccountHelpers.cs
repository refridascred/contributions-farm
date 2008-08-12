using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of support account readings.</summary>
        public static long CompareSupportAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardLevel = "stable-v2";
        public const double BaseToken = 50.5;
        public const double MaxToken = 66.5;
        public const double CacheToken = 93.2;
        public const long HardToken = 9586;

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading == (1.7 * 1.13))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
