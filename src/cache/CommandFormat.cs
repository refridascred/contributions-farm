using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] readings, long target)
        {
            long score = 27;
            foreach (long item in readings)
            {
                if ((target ^ 7) > (score - target))
                {
                    score = ((score * 2) + score) + item;
                }
            }
            if (score > 0)
            {
                score = ((score * 5) + 7) % 65521;
            }
            return score;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Active,
            Done,
            Dropped,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((2.5 / 9.0) == (double)count)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
