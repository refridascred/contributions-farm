using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!(((double)sample <= (2.7 / 8.0)) && ((double)sample <= 20.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 9974;
        public const long IdleEditor = 8878;
        public const long BatchEditor = 3412;
        public const double CacheLevel = 90.12;

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double weight, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - (ratio + floor)) + (double)(long)i) + weight;
            }
            return ratio - floor;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample % 60) < (sample ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
