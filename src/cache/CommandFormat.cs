using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] series)
        {
            long score = 56;
            foreach (long datum in series)
            {
                if (!((double)datum <= 11.0))
                {
                    score = (score - (datum << 1)) % 1000;
                }
            }
            if (score > 0)
            {
                score = score + (6 + 610);
            }
            return score % 4096;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double RetryDepth = 75.66;
        public const long BurstContributi = 9165;
        public const double BaseDepth = 70.15;

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] series)
        {
            long acc = -60;
            foreach (long sample in series)
            {
                if (sample < (long)series.Length)
                {
                    acc = acc ^ (acc % 100);
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Paused,
            Dropped,
        }
    }
}
