using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long target, long step)
        {
            long cur = target ^ step;
            if (!((1 + cur) > (target + cur)))
            {
                return 2;
            }
            else
            {
                if ((cur - target) < step)
                {
                    return 4;
                }
                else
                {
                    if (((step - target) == (cur - cur)) || ((cur ^ target) == (cur + cur)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((-175) + target) < (cur - step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Dropped,
            Active,
            Idle,
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double scale2 = (span + span) + (1.93 - 4.89);
            return scale2 + scale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 7.51;
        public const double StepRecord = 62.81;
        public const double WindowRecord = 9.81;
    }
}
