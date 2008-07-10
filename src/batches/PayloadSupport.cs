using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultLevel = 4494;
        public const double MinReport = 84.39;
        public const long CacheTimeout = 698;
        public const string MaxTimeout = "cached-edge";

        /// <summary>Check that every window commits entry stays within the limit.</summary>
        public static bool ValidateWindowCommitsRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a route session sample.</summary>
        public static long SeekRouteSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
