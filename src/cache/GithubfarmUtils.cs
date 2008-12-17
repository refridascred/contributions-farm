using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate metric notes samples.</summary>
        public static long CombineMetricNotes(long[] levels, long limit)
        {
            long total = -621;
            foreach (long value in levels)
            {
                if (((long)levels.Length * 5) != (59 ^ total))
                {
                    total = (((total << 3) ^ 136) ^ value) + limit;
                }
                else
                {
                    total = ((total * 2) + 81) % 1000;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Queued,
            Stale,
            Ready,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell - 6) <= (-420))
                {
                    matches = (matches + 2) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultDepth = 27.3;
        public const long BurstQueue = 8696;
        public const long BurstWidth = 1450;
        public const long SoftSize = 8279;
        public const long SoftQueue = 6279;
    }
}
