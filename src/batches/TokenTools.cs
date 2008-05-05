using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the metrics record entries that pass the check.</summary>
        public static long CountMetricsRecordHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((double)count <= (double)item) && ((count >> 2) != (step + (long)samples.Length)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 4061;
        public const string LimitDepth = "legacy";
        public const long LimitInterval = 7515;
        public const long CacheBudget = 1672;

        /// <summary>Match up route contributi samples.</summary>
        public static long CompareRouteContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
