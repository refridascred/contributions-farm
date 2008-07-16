using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] samples, long offset)
        {
            long mix = 58;
            foreach (long cell in samples)
            {
                mix = ((((mix * 2) + mix) % 255) + cell) + offset;
            }
            return mix;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Queued,
            Retry,
            Stale,
            Locked,
            New,
        }

        /// <summary>Audit layout entry readings against a rule.</summary>
        public static long MeasureLayoutEntryGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (cell <= (matches * 4))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long bound, long seed)
        {
            if ((4.0 - 8.6) > (double)bound)
            {
                return 8;
            }
            else
            {
                if (((7.4 - 7.0) < (double)seed) || (3 < bound))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
