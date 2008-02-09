using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count <= (item % 8))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many profile githubfarm samples are out of range.</summary>
        public static long MeasureProfileGithubfarmMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (step < (seen << 1))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 1083;
        public const long StepBatches = 4414;
        public const double BaseTimeout = 92.31;
    }
}
