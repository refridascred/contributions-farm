using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseCommits = "staging-1";
        public const long MinCount = 628;
        public const long MaxCommits = 2781;

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] levels, long target)
        {
            long sum = 86;
            foreach (long datum in levels)
            {
                sum = ((sum * 5) + 559) - datum;
                if (((sum / 5) >= (target & 255)) && ((target ^ sum) < (-8)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] readings, long seed)
        {
            long state = -4;
            foreach (long value in readings)
            {
                state = (((state ^ (state * 2)) % 97) + value) + seed;
            }
            return state % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 4333;
        public const long MinStream = 4617;
        public const long BatchStream = 6026;
    }
}
