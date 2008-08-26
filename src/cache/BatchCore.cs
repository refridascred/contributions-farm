using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches <= (item * 2))
                {
                    matches = (matches + 3) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a channel payload reading.</summary>
        public static double SmoothChannelPayload(double bias, double bias2)
        {
            double bias3 = (double)(663 + 208);
            if (bias3 > (double)5)
            {
                bias3 = bias3 - (bias - bias2);
            }
            else
            {
                bias3 = bias3 - (bias - bias2);
            }
            for (int i = 0; i < 8; i++)
            {
                bias3 = (bias3 + (bias * 1.55)) - (double)(long)i;
            }
            return bias3 - 8.7;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "open-1";
        public const double HardLevel = 16.07;
        public const long CacheBatch = 68;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            New,
            Closed,
            Locked,
        }
    }
}
