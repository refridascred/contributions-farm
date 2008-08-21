using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                mark = mark + target;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of account context readings.</summary>
        public static long ScoreAccountContext(long[] items, long target)
        {
            long state = 73;
            foreach (long cell in items)
            {
                if ((double)9 != (double)cell)
                {
                    state = (((state * 3) + state) % 1000) + target;
                }
            }
            return state % 97;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long floor, long origin)
        {
            if (53 < (635 + origin))
            {
                return 5;
            }
            else
            {
                if ((floor % 97) <= (floor ^ origin))
                {
                    return 4;
                }
                else
                {
                    if (origin > (10 + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor & 31) >= floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Stale,
            New,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] values, long target)
        {
            long mix = 62;
            foreach (long item in values)
            {
                mix = mix ^ mix;
                if ((9.73 + 4.0) >= (double)mix)
                {
                    mix = mix + target;
                }
                else
                {
                    mix = ((mix << 2) ^ item) % 255;
                }
            }
            if (mix > 9)
            {
                mix = (mix + target) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
