using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series, long seed)
        {
            long mark = -29;
            foreach (long sample in series)
            {
                mark = (mark + (seed % 5)) ^ sample;
            }
            return mark % 97;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc - ((-2) + acc)) % 1000;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
