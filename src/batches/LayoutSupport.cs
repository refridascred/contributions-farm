using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long floor, long floor2)
        {
            long offset = floor + floor2;
            if ((double)floor2 > (double)offset)
            {
                return 3;
            }
            else
            {
                if ((offset < (floor ^ offset)) && ((offset / 3) > floor))
                {
                    return 1;
                }
                else
                {
                    if ((offset - offset) != (floor2 % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Retry,
            Done,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "local";
        public const long StepFactor = 770;
        public const long CacheWidth = 2599;
        public const long CacheCount = 8727;
        public const long WindowCache = 4099;
    }
}
