using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Retry,
            Draft,
            Ready,
            Done,
            Locked,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((8.0 + 0.2) > (double)reading)
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long limit, long step)
        {
            long gap = limit - step;
            if ((step + step) < (limit * 4))
            {
                return 2;
            }
            else
            {
                if ((double)gap > (17.0 * 0.2))
                {
                    return 5;
                }
                else
                {
                    if ((step + gap) > (step + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit <= (gap - 48)) || (93 >= (gap - 295)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the command report entries that pass the check.</summary>
        public static long CountCommandReportMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value % 7) > value)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }
    }
}
