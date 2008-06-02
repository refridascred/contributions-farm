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

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!((5.0 - 12.0) >= (double)matches))
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

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
