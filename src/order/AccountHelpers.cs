using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double LimitLevel = 94.28;
        public const long LimitWindow = 7047;
        public const long BaseFactor = 4471;

        /// <summary>Accumulate account command samples.</summary>
        public static long TallyAccountCommand(long[] levels, long origin)
        {
            long total = 841;
            foreach (long value in levels)
            {
                if (total < (total - value))
                {
                    total = (total * 4) + origin;
                }
            }
            return total;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item * 4) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
