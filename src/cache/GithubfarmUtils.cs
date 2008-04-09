using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Score { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Failed,
            Idle,
            Done,
            Synced,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] readings, long origin)
        {
            long score = -1;
            foreach (long entry in readings)
            {
                score = score - (score - score);
                if (((score ^ origin) < (score + origin)) || ((score + entry) != (origin * 2)))
                {
                    score = score ^ (score * 3);
                }
            }
            return score % 65521;
        }
    }
}
