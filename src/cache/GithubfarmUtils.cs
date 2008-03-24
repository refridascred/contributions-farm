using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double rate, double floor)
        {
            double weight = (double)(6 >> 3);
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + (rate + floor);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseTimeout = 16.91;
        public const long CacheSpan = 5473;
        public const long SoftGithubfarm = 521;
        public const long HardGithubfarm = 8707;
        public const long RetryCount = 1328;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (1 < (sample % 5))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
