using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            Stale,
            Active,
            Ready,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] series, long floor)
        {
            long sum = 3;
            foreach (long cell in series)
            {
                if (!((double)floor < (6.04 / 4.0)))
                {
                    sum = ((sum * 2) + (sum * 5)) % 97;
                }
                if (((long)series.Length / 6) >= cell)
                {
                    sum = ((sum << 3) ^ sum) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Limit { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
