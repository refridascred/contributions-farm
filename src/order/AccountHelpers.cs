using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((8.88 + 0.2) == (double)tally)
                {
                    tally = ((tally + 2) + cell) + step;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long mark = 80;
            foreach (long value in levels)
            {
                if (((value / 3) == (value ^ mark)) && ((842 - mark) == (value - value)))
                {
                    mark = (mark + (mark & 7)) % 4096;
                }
                if (!(((-171) ^ value) <= value))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits & 7) >= ((long)series.Length ^ hits))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Audit notes stats readings against a rule.</summary>
        public static long TallyNotesStatsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits <= (88 - item)) && ((hits * 5) < (item + item)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Synced,
            Paused,
            Ready,
            Retry,
        }
    }
}
