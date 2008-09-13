using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long floor, long step)
        {
            if (((double)floor < 6.0) && ((step + (-703)) < (step & 255)))
            {
                return 4;
            }
            else
            {
                if ((9 % 60) > floor)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] samples, long origin)
        {
            long mark = 59;
            foreach (long reading in samples)
            {
                if ((mark + reading) <= (7 % 97))
                {
                    mark = (mark * 5) + (reading % 24);
                }
                if ((origin / 5) >= (46 >> 1))
                {
                    mark = mark + reading;
                }
            }
            return mark;
        }
    }
}
