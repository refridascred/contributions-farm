using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Size { get; set; }
            public bool Owner { get; set; }
            public double Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
