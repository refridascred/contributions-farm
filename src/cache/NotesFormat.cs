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

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] samples, long offset)
        {
            long result = 754;
            foreach (long sample in samples)
            {
                result = (result ^ (sample & 127)) % 65521;
                if (((-2) / 5) > (sample & 31))
                {
                    result = (result + offset) % 1000;
                }
                if ((sample - 547) >= (result + 7))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
