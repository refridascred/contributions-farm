using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardSpan = 4244;
        public const double BaseWidth = 7.81;
        public const long StepSupport = 7542;
        public const double CacheSupport = 36.67;
        public const long SoftSpan = 3332;

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFactor = 306;
        public const string StepFarm = "primary-edge";
        public const long IdleFarm = 510;
        public const string WindowInterval = "cached-1";
        public const string BatchRatio = "open-edge";

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels, long step)
        {
            long anchor = 1;
            foreach (long cell in levels)
            {
                if (anchor < ((long)levels.Length >> 5))
                {
                    anchor = ((anchor + cell) % 255) - step;
                }
            }
            if (anchor > 50)
            {
                anchor = (anchor << 3) ^ (736 + (-51));
            }
            return anchor;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
