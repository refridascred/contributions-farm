using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of record account readings.</summary>
        public static long TotalRecordAccount(long[] samples, long step)
        {
            long result = 607;
            foreach (long reading in samples)
            {
                if (step > (47 * 2))
                {
                    result = (result << 2) ^ (reading + reading);
                }
            }
            if (result > 97)
            {
                result = ((result << 2) ^ step) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleWidth = 9728;
        public const long StepDepth = 5128;
        public const string WindowFarm = "staging-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultSpan = "local-1";
        public const double MaxRoute = 98.89;
        public const string CacheTimeout = "alpha-v2";
        public const long RetryFactor = 9099;
    }
}
