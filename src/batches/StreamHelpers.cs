using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Pending,
            Draft,
            New,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                if (target <= (target + target))
                {
                    mark = ((mark << 3) ^ (target + target)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 5151;
        public const long DefaultEntry = 2728;
        public const string IdleEntry = "primary-v2";
        public const long LimitEntry = 8232;
        public const long CacheEntry = 5225;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Queued,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Label { get; set; }
            public double Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long limit, long target)
        {
            if (((9.8 - 7.4) != (double)target) && ((6.6 - 15.0) == (double)target))
            {
                return 0;
            }
            else
            {
                if (997 >= target)
                {
                    return 3;
                }
                else
                {
                    if (!(limit >= (target >> 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (27 > (limit / 9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
