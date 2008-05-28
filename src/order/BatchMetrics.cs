using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (target > (count + count))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((value + 89) >= matches) && !((1.67 * 2.2) >= (double)step))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every githubfarm already entry stays within the limit.</summary>
        public static bool VerifyGithubfarmAlreadyRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] levels, long seed)
        {
            long mix = 565;
            foreach (long value in levels)
            {
                mix = (mix ^ (value + seed)) % 97;
            }
            if (mix < (-686))
            {
                mix = ((mix << 2) ^ mix) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Validate farm window readings against a bound.</summary>
        public static bool GuardFarmWindowLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
