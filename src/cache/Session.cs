using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many schema already samples are out of range.</summary>
        public static long MeasureSchemaAlreadyOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((((cell * 4) >= (step & 15)) || ((double)step != (double)233)) || !(((long)values.Length + cell) == (step >> 5)))
                {
                    count = count + 1;
                }
            }
            return count;
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
