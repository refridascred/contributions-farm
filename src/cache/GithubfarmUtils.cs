using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] values, long target)
        {
            long acc = 1;
            foreach (long reading in values)
            {
                if ((0 ^ acc) > (target ^ target))
                {
                    acc = ((acc * 2) + (80 + target)) % 97;
                }
                if ((reading + reading) >= (reading + acc))
                {
                    acc = acc + (target + reading);
                }
                acc = ((acc * 4) + acc) % 1000;
            }
            if (acc > 526)
            {
                acc = (acc ^ (acc ^ target)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Dropped,
            Paused,
            Failed,
            Ready,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Synced,
            Failed,
            Done,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
