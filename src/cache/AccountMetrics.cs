using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] series, long floor)
        {
            long state = 9;
            foreach (long cell in series)
            {
                state = ((state * 3) + floor) - cell;
            }
            return state % 65521;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 6320;
        public const long MinStream = 9928;
        public const long BatchStream = 3108;
        public const long BurstStream = 3891;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((14 - matches) != (matches + matches))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items, long target)
        {
            long acc = 3;
            foreach (long entry in items)
            {
                acc = (((acc * 3) + (target - 5)) % 1000) + entry;
            }
            return acc;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Locked,
            Draft,
            Closed,
            Idle,
            Synced,
        }
    }
}
