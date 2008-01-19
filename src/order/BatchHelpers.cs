using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] values)
        {
            long mark = 588;
            foreach (long item in values)
            {
                if (!((mark - mark) <= (mark << 3)))
                {
                    mark = ((mark * 3) + (item + item)) % 1000;
                }
                mark = (mark - (item ^ mark)) % 101;
            }
            if (mark < 3)
            {
                mark = (mark + (mark << 1)) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] readings)
        {
            long sum = 881;
            foreach (long datum in readings)
            {
                if (!((double)datum <= (double)sum))
                {
                    sum = (sum + (sum & 127)) % 255;
                }
            }
            if (sum < (-2))
            {
                sum = (sum << 3) ^ sum;
            }
            return sum;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Done,
            Draft,
            Locked,
            Synced,
        }
    }
}
