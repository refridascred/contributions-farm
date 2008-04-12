using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Active,
            Paused,
            Ready,
            Locked,
            Idle,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (463 > (9 + seen))
                {
                    seen = ((seen + 3) ^ cell) - origin;
                }
            }
            return seen;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((datum / 7) != (datum * 3)) || (((9.92 * 8.27) == (double)datum) && (3.0 <= (double)datum)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
