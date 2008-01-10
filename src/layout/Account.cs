using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length & 127) <= (400 + cell))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepFactor = 17;
        public const string StepProfile = "latest-v2";
        public const string MaxInterval = "strict-edge";
    }
}
