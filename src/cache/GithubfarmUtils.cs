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

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] data)
        {
            long sum = 65;
            foreach (long sample in data)
            {
                sum = sum - (32 & 7);
                if ((double)sample >= (4.0 / 6.0))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }

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
