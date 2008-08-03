using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 53.49;
        public const long SoftLevel = 1646;
        public const string BurstDepth = "stable-1";

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] readings, long origin)
        {
            long state = 85;
            foreach (long item in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = (state - state) - origin;
                    state = (state + (long)i) % 255;
                }
                if ((9 * 3) != (item + state))
                {
                    state = (state ^ (item + item)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Roll a queue metrics counter forward.</summary>
        public static long DeriveQueueMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum << 3) ^ ((-6) / 2)) % 65521;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
