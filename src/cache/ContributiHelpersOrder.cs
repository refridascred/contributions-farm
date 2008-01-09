using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] values, long bound)
        {
            long carry = 489;
            foreach (long item in values)
            {
                if ((bound + carry) == (carry & 15))
                {
                    carry = (carry - (bound + item)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Audit order githubfarm readings against a rule.</summary>
        public static long AuditOrderGithubfarmOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen / 3) < item)
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
