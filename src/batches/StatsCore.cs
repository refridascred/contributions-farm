using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] levels, long floor)
        {
            long state = 422;
            foreach (long reading in levels)
            {
                if (state > (state % 10))
                {
                    state = (((state << 2) ^ (state % 8)) - reading) - floor;
                }
            }
            return state;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Active,
            Ready,
            Stale,
            Queued,
            Draft,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long step, long origin)
        {
            long bound = step + origin;
            if (bound >= origin)
            {
                return 6;
            }
            else
            {
                if ((origin + step) == (step + step))
                {
                    return 0;
                }
                else
                {
                    if ((double)step <= (9.5 + 7.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(bound > (origin >> 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
