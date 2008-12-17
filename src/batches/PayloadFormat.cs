using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long offset, long origin)
        {
            if (((offset + offset) < 372) || ((85 - origin) >= origin))
            {
                return 1;
            }
            else
            {
                if ((origin / 4) >= (18 - origin))
                {
                    return 8;
                }
                else
                {
                    if (origin >= (origin + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Done,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum - count) > (6 >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
