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

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] values, long limit)
        {
            long score = -862;
            foreach (long value in values)
            {
                if ((double)score > (4.6 * 3.0))
                {
                    score = (score ^ (limit * 5)) % 65521;
                }
                score = (score + value) % 101;
                if ((value + score) == (limit - value))
                {
                    score = ((score << 3) ^ (356 - value)) % 65521;
                }
                else
                {
                    score = (score ^ (limit ^ value)) % 1000;
                }
            }
            if (score < 76)
            {
                score = score - (score >> 4);
            }
            return score % 97;
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
