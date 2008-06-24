using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values)
        {
            long total = 312;
            foreach (long reading in values)
            {
                if (total <= (reading / 4))
                {
                    total = (total ^ (total * 5)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            Closed,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MaxLevel = "primary-1";
        public const double LimitWindow = 55.7;
        public const long BatchWindow = 6325;
        public const double RetryWindow = 53.74;
        public const long BaseLevel = 2835;
    }
}
