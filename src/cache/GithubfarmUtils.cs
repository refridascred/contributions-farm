using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + step) != (0 + 990))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long step, long bound)
        {
            if (((bound ^ step) > bound) && ((double)bound >= (9.5 - 5.97)))
            {
                return 1;
            }
            else
            {
                if ((step > (bound % 7)) || ((7 * 3) <= (bound - bound)))
                {
                    return 3;
                }
                else
                {
                    if ((bound >= (step + bound)) && (step >= (step / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound << 1) == (7 + bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] items)
        {
            long carry = 596;
            foreach (long value in items)
            {
                if ((carry / 8) < value)
                {
                    carry = carry - (value + carry);
                }
            }
            return carry % 4096;
        }
    }
}
