using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum + seen) >= seen)
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinAlready = "fallback-edge";
        public const double HardAlready = 22.42;
        public const double StepRatio = 10.63;
        public const long BaseRatio = 7841;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((89 / 7) <= floor))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
