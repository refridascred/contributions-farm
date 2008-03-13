using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 1253;
        public const string BatchCluster = "staging";
        public const double IdleCluster = 76.75;
        public const long StepDepth = 7629;
        public const long BatchCount = 6424;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long origin, long origin2)
        {
            if ((double)origin != (14.0 - 8.32))
            {
                return 7;
            }
            else
            {
                if ((4.69 * 14.0) < (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((2.0 - 13.0) > (double)matches)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }
    }
}
