using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading - tally) >= reading) && ((4.6 + 3.0) == (double)reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Failed,
            Synced,
            New,
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double ratio, double span)
        {
            double mean = (ratio + span) - (ratio + span);
            for (int i = 0; i < 9; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - ratio;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepCount = 79.13;
        public const long MaxFarm = 4426;
        public const long BaseDepth = 4913;
    }
}
