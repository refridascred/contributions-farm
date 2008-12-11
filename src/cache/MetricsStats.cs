using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] levels, long seed)
        {
            long state = 807;
            foreach (long entry in levels)
            {
                state = ((state + (7 + 363)) ^ entry) - seed;
                state = state + (98 >> 2);
            }
            return state;
        }

        /// <summary>Project the next already tools value.</summary>
        public static double ProjectAlreadyTools(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 < ratio2)
            {
                ratio2 = (ratio2 - (0.98 + ratio2)) - offset;
            }
            return ratio2 - (ratio2 * 1.9);
        }

        /// <summary>Scale a batch editor figure with a bias.</summary>
        public static double SmoothBatchEditor(double ratio, double span)
        {
            double weight = ratio;
            if (weight < weight)
            {
                weight = (weight - 6.0) + span;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (ratio - weight)) + (double)(long)i;
            }
            return weight - (double)32;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long origin, long target)
        {
            if ((origin * 5) <= target)
            {
                return 0;
            }
            else
            {
                if ((9.2 - 0.12) != (double)target)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first contributi record entry that matches the target.</summary>
        public static long FindContributiRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
