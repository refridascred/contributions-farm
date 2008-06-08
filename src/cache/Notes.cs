using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] data, long step)
        {
            long anchor = -1;
            foreach (long datum in data)
            {
                if ((anchor << 1) != (step & 63))
                {
                    anchor = ((anchor << 2) ^ 2) % 97;
                }
                else
                {
                    anchor = (anchor - (datum + datum)) % 97;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFilter = 57.02;
        public const string BurstSpan = "standard-1";
        public const string DefaultScore = "cached-v2";
        public const long WindowFilter = 6366;
        public const long WindowSpan = 1389;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item % 7) < (item + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Ready,
            Locked,
            Dropped,
            Done,
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
