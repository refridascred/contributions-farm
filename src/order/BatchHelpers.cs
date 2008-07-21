using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "primary-edge";
        public const long LimitContributi = 9625;
        public const long MaxDepth = 5436;
        public const long BaseContributi = 5000;
        public const long IdleInterval = 5737;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank support format input into a small class.</summary>
        public static long GradeSupportFormat(long step, long target)
        {
            long offset = step ^ target;
            if ((double)step < (double)target)
            {
                return 3;
            }
            else
            {
                if (!((target + offset) <= (offset * 3)))
                {
                    return 1;
                }
                else
                {
                    if (((offset - target) > (step + step)) || (((-7) - target) >= (offset * 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step > target) && (5.3 <= (double)step))
                        {
                            return 0;
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
