using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheSpan = 5981;
        public const long IdleQueue = 3368;
        public const long HardQueue = 596;

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double ratio, double offset)
        {
            double load = ratio / 7.0;
            if (load > (load * 3.0))
            {
                load = load - 3.0;
            }
            else
            {
                load = load + (offset - 4.4);
            }
            return load - (double)8;
        }
    }
}
