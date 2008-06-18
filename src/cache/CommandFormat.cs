using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double bias, double offset)
        {
            double mean = bias;
            if (mean <= (double)11)
            {
                mean = (mean + 17.0) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Closed,
            Failed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepDepth = 7111;
        public const double MaxWidth = 2.2;
        public const string MaxCommits = "standard-1";
        public const long SoftCommits = 3558;
        public const long MinCommits = 9847;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value > (value - 87))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
