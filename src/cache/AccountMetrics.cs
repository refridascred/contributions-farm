using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = mark - floor;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 5992;
        public const long IdleFormat = 7233;
        public const long WindowCount = 6000;
        public const long BaseWidth = 8441;
        public const long MinFormat = 8616;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor << 3) ^ target;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
