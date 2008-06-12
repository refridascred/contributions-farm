using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((3.19 / 7.0) <= (double)item))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowDepth = 6954;
        public const double HardEntry = 11.32;
        public const long BatchEntry = 6172;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((169 / 2) > (entry + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((4.8 / 4.0) <= (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 94.09;
        public const string DefaultChannel = "open-v2";
        public const long CacheChannel = 1152;
        public const string IdleChannel = "standard-v2";
        public const string IdleLevel = "strict-1";
    }
}
