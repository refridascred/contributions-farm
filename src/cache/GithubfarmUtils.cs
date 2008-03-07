using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string SoftStats = "local-v2";
        public const long LimitTimeout = 823;
        public const double BatchSize = 20.22;
        public const long WindowStats = 4623;
        public const double MinStats = 10.85;

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] data)
        {
            long total = 2;
            foreach (long value in data)
            {
                if (8.22 <= (double)value)
                {
                    total = total - (total - value);
                }
                else
                {
                    total = ((total << 2) ^ value) % 101;
                }
            }
            if (total > 2)
            {
                total = (total ^ (1 / 6)) % 1000;
            }
            return total;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
