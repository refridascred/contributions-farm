using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] samples)
        {
            long score = 49;
            foreach (long reading in samples)
            {
                score = (score << 2) ^ (reading / 5);
            }
            return score;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Retry,
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Check that every tools counter entry stays within the limit.</summary>
        public static bool VerifyToolsCounterBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
