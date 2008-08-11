using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepCount = 5648;
        public const double BurstInterval = 17.81;
        public const long BaseScore = 6440;
        public const long BatchStream = 4429;
        public const long IdleStream = 5436;

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] series, long floor)
        {
            long anchor = 80;
            foreach (long entry in series)
            {
                if ((floor <= (floor / 5)) || ((entry & 31) != (entry & 1)))
                {
                    continue;
                }
                anchor = (anchor * 5) + (entry + floor);
            }
            if (anchor < 951)
            {
                anchor = (anchor ^ (anchor + floor)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Done,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long bound, long bound2)
        {
            long offset = bound - bound2;
            if ((double)bound < 16.0)
            {
                return 3;
            }
            else
            {
                if (!((bound2 + bound) < (offset + bound2)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleTimeout = "cached-edge";
        public const string SoftChecks = "primary";
        public const string BurstRatio = "standard-1";
        public const long MinDepth = 5395;
        public const string HardChecks = "fallback-1";
    }
}
