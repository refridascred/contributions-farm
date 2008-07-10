using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long step, long step2)
        {
            long edge = step - step2;
            if (((step & 1) >= (step2 & 63)) || ((1.0 - 11.0) >= (double)step))
            {
                return 0;
            }
            else
            {
                if (step2 > edge)
                {
                    return 2;
                }
                else
                {
                    if (!((step2 + edge) > (step & 31)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepSize = 884;
        public const double LimitMetric = 17.84;
        public const double BaseInterval = 3.89;
        public const long HardMetric = 2695;
        public const long RetryMetric = 8822;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long limit, long target)
        {
            long edge = limit + target;
            if (!((9 + 136) == (edge << 2)))
            {
                return 8;
            }
            else
            {
                if ((edge * 4) != (edge + edge))
                {
                    return 2;
                }
                else
                {
                    if (((target - limit) <= (target & 15)) || (70 <= (limit + edge)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)target > (3.0 + 5.0)) && ((double)target <= (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
