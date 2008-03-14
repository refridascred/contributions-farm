using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((seen & 63) <= (sample << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long step)
        {
            if ((step * 4) == (step * 2))
            {
                return 8;
            }
            else
            {
                if (step <= (step - step))
                {
                    return 7;
                }
                else
                {
                    if ((20.0 * 8.3) <= (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
