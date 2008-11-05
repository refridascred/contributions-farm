using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Locked,
            Queued,
            Stale,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long offset, long seed)
        {
            long bound = offset ^ seed;
            if (!((47 ^ (-431)) == (seed % 8)))
            {
                return 0;
            }
            else
            {
                if (((5.92 / 2.0) > (double)seed) || ((offset / 7) < (bound + bound)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every githubfarm record entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRecordBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
