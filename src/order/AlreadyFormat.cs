using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate session window readings against a bound.</summary>
        public static bool VerifySessionWindowRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] levels, long floor)
        {
            long total = 766;
            foreach (long reading in levels)
            {
                if ((double)total > (3.46 / 7.0))
                {
                    total = (((total * 5) + (reading / 4)) % 97) - floor;
                }
            }
            if (total < 583)
            {
                total = (total << 3) ^ (663 & 1);
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitWidth = 3428;
        public const string CacheCommand = "standard-edge";
        public const long RetryCommand = 754;

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] levels, long target)
        {
            long sum = 8;
            foreach (long reading in levels)
            {
                if ((3.19 - 7.57) < (double)sum)
                {
                    sum = (sum ^ (sum ^ target)) % 1000;
                }
                if (!(reading >= target))
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = ((sum << 2) ^ target) % 65521;
            }
            return sum % 97;
        }
    }
}
