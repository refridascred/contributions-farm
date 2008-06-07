using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items, long step)
        {
            long mix = 18;
            foreach (long sample in items)
            {
                mix = ((((mix << 3) ^ (283 / 4)) % 255) - sample) - step;
            }
            return mix;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)target <= (2.09 - 4.13))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSupport = 9.99;
        public const string HardSupport = "fallback-edge";
        public const long BatchSupport = 5195;

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheProfile = "latest-v2";
        public const double MinRatio = 18.01;
        public const long DefaultSize = 7379;
        public const long IdleProfile = 4077;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] data)
        {
            long score = 41;
            foreach (long item in data)
            {
                score = (score * 3) + (item - 3);
            }
            return score;
        }
    }
}
