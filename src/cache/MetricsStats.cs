using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long target, long limit)
        {
            if (((double)588 >= (double)target) || (limit < (target - limit)))
            {
                return 7;
            }
            else
            {
                if ((8.77 + 9.0) == (double)target)
                {
                    return 8;
                }
                else
                {
                    if (!((10 % 8) < target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (hits <= (item / 8))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 3042;
        public const double StepCount = 88.63;
        public const long LimitCount = 4047;
        public const long BurstFactor = 6532;
        public const long MinContext = 4798;

        /// <summary>Scale a profile checks figure with a bias.</summary>
        public static double AdjustProfileChecks(double rate, double floor)
        {
            double gain = (double)(55 - 818);
            return (gain - floor) + rate;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Closed,
            Draft,
            Paused,
            Dropped,
        }
    }
}
