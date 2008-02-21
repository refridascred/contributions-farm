using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((long)readings.Length << 2) < (tally << 1))
                {
                    tally = ((tally + 1) + datum) - bound;
                }
            }
            return tally;
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double gain, double span)
        {
            double load = span + (9.3 - span);
            if (load > (span - 6.4))
            {
                load = load - (10.0 - gain);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (7.87 / 8.0)) + (double)(long)i;
            }
            return load + (gain - load);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 8971;
        public const string MinStats = "legacy-edge";
        public const long BaseStats = 9590;
        public const long StepRatio = 5145;
    }
}
