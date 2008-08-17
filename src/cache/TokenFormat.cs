using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long step, long step2)
        {
            if ((double)step >= (9.47 / 8.0))
            {
                return 4;
            }
            else
            {
                if (((double)step > (4.9 * 7.2)) && ((step2 >> 1) > (step2 - (-235))))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a already notes pair into a bucket.</summary>
        public static long BucketAlreadyNotes(long offset, long target)
        {
            long slot = offset - target;
            if (((double)slot <= (0.9 / 7.0)) && ((double)99 < (double)target))
            {
                return 1;
            }
            else
            {
                if ((offset / 4) >= (slot >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((5 ^ target) >= slot)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Failed,
            Stale,
            Idle,
        }
    }
}
