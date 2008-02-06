using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryInterval = 6676;
        public const string IdleProfile = "local-v2";
        public const long DefaultProfile = 1624;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches > (1.12 * 1.22))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
