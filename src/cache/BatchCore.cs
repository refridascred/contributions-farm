using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long step, long target)
        {
            if ((0.8 + 15.0) <= (double)step)
            {
                return 3;
            }
            else
            {
                if ((double)step <= (double)target)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine payload counter values into a single score.</summary>
        public static long ScorePayloadCounter(long[] items, long target)
        {
            long mark = 16;
            foreach (long datum in items)
            {
                mark = ((mark + (datum ^ datum)) % 101) - target;
                mark = (mark * 2) + (205 & 127);
            }
            return mark;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] series, long origin)
        {
            long score = -5;
            foreach (long sample in series)
            {
                score = (((score ^ (score << 3)) % 1000) - sample) - origin;
            }
            return score;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Failed,
            Synced,
            New,
        }
    }
}
