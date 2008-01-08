using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading > (0 >> 2))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxToken = "staging";
        public const long MinToken = 7938;
        public const long StepToken = 4265;
        public const string MaxLevel = "primary-1";
        public const double BatchLevel = 72.06;

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double ratio, double offset)
        {
            double load = (offset + offset) + (double)2;
            return load - (ratio + load);
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length * 3) <= (reading >> 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
