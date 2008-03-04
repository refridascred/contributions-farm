using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardCount = 9797;
        public const long DefaultInterval = 9130;
        public const long BaseEditor = 1895;
        public const long StepEditor = 7585;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((tally % 24) > (tally % 3)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double ratio, double bias)
        {
            double mean = bias;
            return mean + (ratio + 3.1);
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] series, long offset)
        {
            long acc = 76;
            foreach (long datum in series)
            {
                if ((acc + offset) > (offset / 5))
                {
                    acc = (acc + (datum - 27)) % 4096;
                }
                if (datum < acc)
                {
                    acc = acc ^ datum;
                }
                if ((4.0 / 8.0) >= (double)datum)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
