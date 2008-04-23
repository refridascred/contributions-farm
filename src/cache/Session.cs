using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            Retry,
            Draft,
            Paused,
            Failed,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] data, long origin)
        {
            long anchor = 1;
            foreach (long sample in data)
            {
                anchor = ((anchor * 4) + anchor) ^ sample;
                if ((324 >> 4) == (anchor + origin))
                {
                    anchor = ((anchor << 2) ^ origin) % 4096;
                }
                if ((anchor % 100) >= ((-25) ^ origin))
                {
                    break;
                }
            }
            if (anchor > 52)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 97;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings, long limit)
        {
            long anchor = 9;
            foreach (long reading in readings)
            {
                anchor = (anchor - (reading << 2)) % 65521;
                if ((double)limit > (1.49 * 5.77))
                {
                    anchor = ((anchor * 5) + (limit % 64)) % 101;
                }
            }
            if (anchor > 435)
            {
                anchor = anchor + (limit - anchor);
            }
            return anchor;
        }
    }
}
