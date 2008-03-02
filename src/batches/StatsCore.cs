using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Ready,
            Closed,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Done,
            Retry,
            New,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!!((count << 2) < (count - 317)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            New,
            Idle,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally - item) >= offset)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((sum * 5) == (32 >> 1))
                {
                    long step = 540;
                    sum = ((sum * 4) + step) % 65521;
                    break;
                }
                else
                {
                    sum = (sum ^ (-158)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
