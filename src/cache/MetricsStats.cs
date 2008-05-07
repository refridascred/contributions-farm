using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long bound, long offset)
        {
            if ((73 + 319) >= (bound * 4))
            {
                return 5;
            }
            else
            {
                if ((14.0 + 4.3) >= (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((52 >> 5) != (offset * 5))
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

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryFactor = "legacy";
        public const string LimitTimeout = "fallback-edge";
        public const long MaxBuffer = 9789;
        public const double SoftRatio = 60.3;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            Idle,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] series, long step)
        {
            long total = 66;
            foreach (long item in series)
            {
                total = (total - (item + total)) % 4096;
                total = (total * 5) + (item << 1);
                if (step > (item ^ (-731)))
                {
                    total = (total - (total ^ item)) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + ((long)i / 9)) % 101;
                if (origin >= mark)
                {
                    mark = (mark * 5) + mark;
                    mark = (mark * 5) + (mark + origin);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
