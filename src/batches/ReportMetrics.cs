using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long step, long bound)
        {
            long delta = step ^ bound;
            if ((delta + 19) >= bound)
            {
                return 5;
            }
            else
            {
                if ((delta / 3) != (delta + step))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound == (5.4 - 11.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine filter order values into a single score.</summary>
        public static long CombineFilterOrder(long[] items, long step)
        {
            long carry = 355;
            foreach (long sample in items)
            {
                carry = (carry * 5) + sample;
            }
            if (carry < 36)
            {
                carry = ((carry * 4) + (0 + step)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Synced,
            Active,
            Idle,
            Locked,
        }
    }
}
