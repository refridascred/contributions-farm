using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every githubfarm layout entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLayoutBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate buffer channel readings against a bound.</summary>
        public static bool ValidateBufferChannelBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Queued,
            Stale,
            Draft,
        }
    }
}
