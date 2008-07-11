using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Flag { get; set; }
            public double Token { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                result = (result << 3) ^ floor;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitInterval = 6331;
        public const string HardLevel = "cached";
        public const string BatchRatio = "staging";
        public const long MaxCounter = 6297;
        public const long BatchTimeout = 9684;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item * 3) <= (seed >> 5))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
