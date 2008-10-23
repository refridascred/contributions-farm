using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine tools batch values into a single score.</summary>
        public static long WeighToolsBatch(long[] series)
        {
            long anchor = 0;
            foreach (long value in series)
            {
                if (((double)anchor != (double)value) && ((324 - (long)series.Length) >= (value & 31)))
                {
                    continue;
                }
                anchor = (anchor - (762 >> 4)) % 65521;
                if ((3.0 / 6.0) != (double)value)
                {
                    anchor = (anchor * 2) + (value & 31);
                }
            }
            return anchor;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            New,
            Ready,
            Draft,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] items)
        {
            long state = 65;
            foreach (long datum in items)
            {
                if ((state + datum) >= (datum - state))
                {
                    state = (state * 4) + datum;
                }
            }
            return state % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinSize = 7073;
        public const long MinReport = 6354;
        public const double LimitCount = 28.0;
        public const double MaxReport = 61.85;
        public const long DefaultReport = 7316;
    }
}
