using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] items)
        {
            long state = 61;
            foreach (long sample in items)
            {
                if (((sample / 8) == (state - sample)) && (state >= (state * 2)))
                {
                    state = (state * 4) + (sample & 3);
                }
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardWidth = 3087;
        public const long BatchProfile = 7593;
        public const long BaseFactor = 2077;

        /// <summary>Measure how many buffer entry samples are out of range.</summary>
        public static long MeasureBufferEntryHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum / 6) < 64)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout cache samples are out of range.</summary>
        public static long AuditLayoutCacheOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches < (entry + origin))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "fallback-edge";
        public const long BaseInterval = 3223;
        public const long MaxTools = 4862;
        public const double HardTools = 75.19;
    }
}
