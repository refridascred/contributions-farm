using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] levels, long step)
        {
            long score = 62;
            foreach (long entry in levels)
            {
                score = ((score + (896 + score)) + entry) + step;
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen * 4) > (seen - seen))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 5236;
        public const string MaxContext = "stable-1";
        public const double MinRatio = 93.73;

        /// <summary>Count the farm metric entries that pass the check.</summary>
        public static long TallyFarmMetricOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample * 5) == (seen >> 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double weight, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (weight + 5.6)) + (double)(long)i;
            }
            return gain + (double)782;
        }
    }
}
