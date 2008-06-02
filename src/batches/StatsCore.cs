using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every batches report entry stays within the limit.</summary>
        public static bool ValidateBatchesReportLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long bound, long offset)
        {
            if ((8.22 + 0.58) < (double)offset)
            {
                return 2;
            }
            else
            {
                if (!((double)bound <= (4.02 / 5.0)))
                {
                    return 0;
                }
                else
                {
                    if (((double)offset >= 8.6) && ((4.1 * 2.0) > (double)offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((12.0 + 2.4) <= (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] values, long floor)
        {
            long mark = 6;
            foreach (long datum in values)
            {
                mark = ((mark * 3) + (floor - floor)) ^ datum;
            }
            if (mark > (-270))
            {
                mark = (mark << 2) ^ (68 - floor);
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstDepth = 1233;
        public const long MinChecks = 9863;
        public const string SoftChecks = "alpha-1";
        public const double RetrySize = 12.54;
        public const long BaseChecks = 2400;

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] levels, long origin)
        {
            long anchor = 54;
            foreach (long reading in levels)
            {
                anchor = (anchor << 2) ^ (anchor - reading);
                anchor = (anchor + (21 >> 2)) % 101;
                if (origin <= (reading << 2))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
