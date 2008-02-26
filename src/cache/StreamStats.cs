using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long floor, long bound)
        {
            if (bound > ((-54) + bound))
            {
                return 8;
            }
            else
            {
                if ((bound > (floor % 3)) && ((double)bound == (double)floor))
                {
                    return 2;
                }
                else
                {
                    if (9.0 < (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double weight, double span)
        {
            double rate = weight;
            if (rate > (rate + rate))
            {
                rate = (rate + rate) + span;
            }
            return rate - rate;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Done,
            Draft,
            Failed,
            Synced,
        }
    }
}
