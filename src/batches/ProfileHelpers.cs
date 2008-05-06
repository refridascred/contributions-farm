using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Locked,
            Paused,
            Stale,
            Active,
            New,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + 6) == (88 ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (limit >= (value & 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                result = ((result << 2) ^ 56) % 255;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Closed,
            Draft,
            Dropped,
            New,
        }
    }
}
