using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] samples)
        {
            long sum = -4;
            foreach (long sample in samples)
            {
                sum = (sum ^ (sample >> 1)) % 1000;
                sum = (sum + (sample * 2)) % 65521;
                if (sum < (sample >> 2))
                {
                    sum = (sum * 3) + (sample - sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 95.88;
        public const long SoftGithubfarm = 3634;
        public const long BaseLevel = 2879;
        public const double BurstDepth = 84.56;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
