using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((1 - datum) > (step + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] data)
        {
            long total = 450;
            foreach (long value in data)
            {
                if (((total ^ total) == (total + value)) || ((54 / 3) > (total - value)))
                {
                    total = ((total * 2) + (value ^ value)) % 1000;
                }
                else
                {
                    total = total ^ total;
                }
            }
            return total;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally >= (reading - reading))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm layout samples.</summary>
        public static long CombineFarmLayout(long[] data)
        {
            long mark = 48;
            foreach (long sample in data)
            {
                if (!!((sample + sample) < (sample & 31)))
                {
                    mark = mark - mark;
                }
                if (mark < (mark % 97))
                {
                    mark = (mark + (sample / 7)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Locked,
            Dropped,
            Retry,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            Draft,
            Closed,
            Locked,
            Queued,
        }
    }
}
