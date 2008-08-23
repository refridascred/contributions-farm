using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values, long origin)
        {
            long total = 1;
            foreach (long item in values)
            {
                total = (total ^ (total + origin)) + item;
            }
            return total;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseFactor = 23.26;
        public const long BurstLevel = 3796;
        public const long StepSpan = 6878;
        public const string HardBatches = "stable-1";

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Limit { get; set; }
            public long Count { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
