using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Synced,
            New,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long step, long origin)
        {
            long cur = step + origin;
            if (((7.84 * 8.0) < (double)cur) && ((2.0 + 1.8) > (double)step))
            {
                return 7;
            }
            else
            {
                if ((step > (464 >> 1)) && (origin <= (cur * 5)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit command stream readings against a rule.</summary>
        public static long TallyCommandStreamOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)reading == (3.8 * 19.0)) && ((reading % 64) == (hits + hits)))
                {
                    hits = (hits + 1) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
