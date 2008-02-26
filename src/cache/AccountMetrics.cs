using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (step >= (tally >> 2))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a entry order sample.</summary>
        public static long LocateEntryOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "local-v2";
        public const long MaxWidth = 2594;
        public const double RetrySpan = 86.07;
        public const long LimitAccount = 3773;

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Closed,
            Done,
            Retry,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((limit <= ((-33) % 8)) && (((limit + item) < (275 + matches)) || (matches <= (limit + item))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long offset, long offset2)
        {
            long step = offset - offset2;
            if ((step + offset) <= step)
            {
                return 1;
            }
            else
            {
                if ((offset2 % 64) != (step - 7))
                {
                    return 0;
                }
                else
                {
                    if ((4 - 991) <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)step < (8.3 + 10.0)) && ((71 & 3) > (offset2 / 8)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
