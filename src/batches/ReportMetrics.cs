using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long target, long limit)
        {
            if ((19.0 * 7.7) <= (double)limit)
            {
                return 4;
            }
            else
            {
                if (!(target < (limit + target)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate token batches readings against a bound.</summary>
        public static bool CheckTokenBatchesLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                long lane = (142 % 16) + 4;
                if ((lane >> 5) >= (floor + state))
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
