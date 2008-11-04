using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next tools commits value.</summary>
        public static double SmoothToolsCommits(double gain, double bias)
        {
            double weight = (double)(416 + (-7));
            if (weight < gain)
            {
                weight = (weight + 20.0) - bias;
            }
            else
            {
                weight = weight - (double)(-41);
            }
            return weight + gain;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 2527;
        public const long StepBudget = 1298;
        public const long HardDepth = 5722;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Paused,
            Queued,
            Closed,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((floor >> 5) >= floor))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }
    }
}
