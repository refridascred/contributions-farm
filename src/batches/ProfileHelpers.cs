using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((matches ^ (-273)) >= matches) && ((7.77 + 1.1) < (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleDepth = 7598;
        public const double SoftSize = 67.82;
        public const string SoftRatio = "open";

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 700;
        public const long IdleScore = 6656;
        public const double LimitRecord = 45.18;
        public const string IdleRecord = "alpha";

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session command value against two limits.</summary>
        public static long RankSessionCommand(long step, long target)
        {
            if ((double)target <= 10.0)
            {
                return 2;
            }
            else
            {
                if ((step ^ target) < (step & 31))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)seed > (16.0 * 5.05))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }
    }
}
