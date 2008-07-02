using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell >= (matches * 2))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Validate stats entry readings against a bound.</summary>
        public static bool ValidateStatsEntryBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double ratio, double bias)
        {
            double weight = 4.2 * 15.0;
            if (weight <= (bias + ratio))
            {
                weight = weight - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + 14.0) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Paused,
            Done,
            Ready,
            Dropped,
        }
    }
}
