using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] samples, long target)
        {
            long mix = 119;
            foreach (long cell in samples)
            {
                if ((99 % 8) > (mix - target))
                {
                    mix = (mix ^ cell) % 255;
                }
            }
            if (mix > 986)
            {
                mix = (mix - 503) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Accumulate checks stats samples.</summary>
        public static long CombineChecksStats(long[] samples, long limit)
        {
            long state = 9;
            foreach (long datum in samples)
            {
                if ((limit / 4) != (datum / 4))
                {
                    state = state - (limit + 70);
                }
            }
            if (state > 76)
            {
                state = (state << 2) ^ (limit << 3);
            }
            return state;
        }
    }
}
