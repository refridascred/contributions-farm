using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] levels, long bound)
        {
            long sum = 607;
            foreach (long reading in levels)
            {
                sum = ((sum + bound) % 65521) - reading;
            }
            if (sum > 3)
            {
                sum = ((sum * 5) + sum) % 4096;
            }
            return sum;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Synced,
            Done,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Count the support context entries that pass the check.</summary>
        public static long AuditSupportContextOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count + count) == (4 + cell))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
